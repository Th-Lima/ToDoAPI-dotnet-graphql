using ToDoAPI.src.Database.Domain;

namespace ToDoAPI.src.Database.Repositories
{
    public interface ITaskRepository
    {
         IQueryable<Todo> GetAll();

         Todo GetById(Guid id);

         Todo Save(Todo entity);
    }
}
