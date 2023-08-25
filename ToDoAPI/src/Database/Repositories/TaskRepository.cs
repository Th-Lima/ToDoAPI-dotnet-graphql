using ToDoAPI.src.Database.Domain;

namespace ToDoAPI.src.Database.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoContext _db;

        public TaskRepository(TodoContext db)
        {
            _db = db;
        }

        public IQueryable<Todo> GetAll()
        {
            return _db.Tasks.AsQueryable();
        }

        public Todo GetById(Guid id)
        {
            return _db.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public Todo Save(Todo entity)
        {
            if(!entity.Id.HasValue)
            {
                entity.Id = Guid.NewGuid();
                _db.Tasks.Add(entity);
            }

            _db.SaveChanges();

            return entity;
        }
    }
}
