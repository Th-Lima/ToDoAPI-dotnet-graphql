using ToDoAPI.src.Database.Domain;

namespace ToDoAPI.src.Api
{
    public class Query
    {
        public Todo Task()
        {
            return new Todo()
            {
                Title = "Teste"
            };
        }
    }
}
