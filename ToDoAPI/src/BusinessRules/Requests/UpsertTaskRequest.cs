namespace ToDoAPI.src.BusinessRules.Requests
{
    public class UpsertTaskRequest
    {
        public Guid? Id { get; set; }

        public required string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }
    }
}
