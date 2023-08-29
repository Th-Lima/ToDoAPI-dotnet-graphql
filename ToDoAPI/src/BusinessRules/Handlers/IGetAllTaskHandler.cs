using ToDoAPI.src.BusinessRules.Responses;

namespace ToDoAPI.src.BusinessRules.Handlers
{
    public interface IGetAllTaskHandler
    {
        TaskListResponse Execute();
    }
}
