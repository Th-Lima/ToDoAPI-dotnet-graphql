using ToDoAPI.src.BusinessRules.Responses;

namespace ToDoAPI.src.BusinessRules.Handlers.Abstractions
{
    public interface IGetAllTaskHandler
    {
        TaskListResponse Execute();
    }
}
