using ToDoAPI.src.BusinessRules.Requests;
using ToDoAPI.src.BusinessRules.Responses;
using ToDoAPI.src.BusinessRules.Validators;
using ToDoAPI.src.Database.Domain;
using ToDoAPI.src.Database.Repositories;

namespace ToDoAPI.src.BusinessRules.Handlers
{
    public class UpsertTaskHandler : IUpsertTaskHandler
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskValidator _validator;

        public UpsertTaskHandler(ITaskRepository taskRepository, ITaskValidator validator)
        {
            _taskRepository = taskRepository;
            _validator = validator;
        }

        public UpsertTaskResponse Execute(UpsertTaskRequest request)
        {
            var validationResult = _validator.Validate(request);
            
            if(!validationResult.IsValid)
            {
                return new UpsertTaskResponse
                {
                    Errors = validationResult.Errors
                };
            }

            Todo entity;

            if(request.Id.HasValue)
                entity = _taskRepository.GetById(request.Id.Value) ?? throw new Exception("Tarefa não encontrada!");
            else
                entity = new Todo();

            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.IsDone = request.IsDone;

            if(request.IsDone)
                entity.DateDone = DateTime.Now;
            else
                entity.DateDone = null;
            
            _taskRepository.Save(entity);
            
            return new UpsertTaskResponse
            {
                Payload = new UpsertTaskResponsePayload
                {
                    Id = entity.Id.Value,
                    Title = entity.Title,
                    Description = entity.Description,
                    DateDone = entity.DateDone,
                    IsDone = entity.IsDone
                }
            };
        }
    }
}
