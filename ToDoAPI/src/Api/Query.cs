using ToDoAPI.src.BusinessRules.Handlers.Abstractions;
using ToDoAPI.src.BusinessRules.Requests;
using ToDoAPI.src.BusinessRules.Responses;

namespace ToDoAPI.src.Api
{
    public class Query
    {
        public TaskResponse GetTaskById([Service] IGetByIdTaskHandler handler, GetByIdTaskRequest request) => 
        handler.Execute(request);

        public TaskListResponse GetAllTasks([Service] IGetAllTaskHandler handler) =>
        handler.Execute();
    }
}
