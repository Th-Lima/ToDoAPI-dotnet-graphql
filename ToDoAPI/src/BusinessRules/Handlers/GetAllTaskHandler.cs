using ToDoAPI.src.BusinessRules.Handlers.Abstractions;
using ToDoAPI.src.BusinessRules.Responses;
using ToDoAPI.src.Database.Repositories;

namespace ToDoAPI.src.BusinessRules.Handlers
{
    public class GetAllTaskHandler : IGetAllTaskHandler
    {
        private readonly ITaskRepository _taskRepository;

        public GetAllTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public TaskListResponse Execute()
        {
            var tasks = _taskRepository.GetAll()
            .Select(x => new TaskResponseItem
            {
                Id = x.Id.Value,
                Title = x.Title,
                Description = x.Description,
                DateDone = x.DateDone,
                Done = x.IsDone
            })
            .ToList();

            return new TaskListResponse
            {
                Payload = tasks
            };
        }
    }
}
