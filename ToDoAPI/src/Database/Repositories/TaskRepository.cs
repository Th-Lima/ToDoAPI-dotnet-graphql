using ToDoAPI.src.Database.Domain;

namespace ToDoAPI.src.Database.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoContext _db;

        public TaskRepository(TodoContext db)
        {
            _db = db;

            //Initial data setup
            InitializeData();
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

        private void InitializeData()
        {
            var tasks = new List<Todo>
            {
                new Todo
                {
                    Id = Guid.Parse("74d32ee4-3b7b-4f49-8264-e5540b38f9cf"),
                    Title = "Tarefa 1",
                    Description = "Tarefa 1 criada",
                    DateDone = null,
                    IsDone  = false               
                },
                new Todo
                {
                    Id = Guid.Parse("5978e3a0-4412-439a-b63b-2d1e8336419d"),
                    Title = "Tarefa 2",
                    Description = "Tarefa 2 criada",
                    DateDone = null,
                    IsDone  = false               
                }
            };

            foreach (var item in tasks)
            {
                _db.Add(item);
            }

            _db.SaveChanges();
        }
    }
}
