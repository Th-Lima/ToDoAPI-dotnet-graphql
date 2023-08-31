using ToDoAPI.src.BusinessRules.Handlers.Abstractions;
using ToDoAPI.src.BusinessRules.Requests;
using ToDoAPI.src.BusinessRules.Responses;
using ToDoAPI.src.Database.Repositories;

namespace ToDoAPI.src.BusinessRules.Handlers
{
    public class GetByIdTaskHandler : IGetByIdTaskHandler
    {
        private readonly ITaskRepository _taskRepository;

        public GetByIdTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public TaskResponse Execute(GetByIdTaskRequest request)
        {
            var task = _taskRepository.GetById(request.Id) ?? throw new Exception("Tarefa não encontrada!");
            
            return new TaskResponse
            {
                Payload = new TaskResponseItem
                {
                    Id = task.Id.Value,
                    Title = task.Title,
                    Description = task.Description,
                    DateDone = task.DateDone,
                    Done = task.IsDone
                }
            };
        }
    }
}
