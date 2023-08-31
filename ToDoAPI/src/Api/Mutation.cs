using ToDoAPI.src.BusinessRules.Handlers.Abstractions;
using ToDoAPI.src.BusinessRules.Requests;
using ToDoAPI.src.BusinessRules.Responses;

namespace ToDoAPI.src.Api
{
    public class Mutation
    {
        public UpsertTaskResponse UpsertTask([Service] IUpsertTaskHandler handler, UpsertTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}
