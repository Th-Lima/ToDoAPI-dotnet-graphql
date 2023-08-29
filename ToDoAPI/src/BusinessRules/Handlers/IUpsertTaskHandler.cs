using ToDoAPI.src.BusinessRules.Requests;
using ToDoAPI.src.BusinessRules.Responses;

namespace ToDoAPI.src.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
         UpsertTaskResponse Execute(UpsertTaskRequest request);
    }
}
