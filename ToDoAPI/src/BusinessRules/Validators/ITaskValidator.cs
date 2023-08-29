using FluentValidation;
using ToDoAPI.src.BusinessRules.Requests;

namespace ToDoAPI.src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {
         
    }
}
