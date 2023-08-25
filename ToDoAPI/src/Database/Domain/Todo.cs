namespace ToDoAPI.src.Database.Domain
{
    public class Todo
    {
        public Guid? Id { get; set; }

        public required string Title { get; set; }   
        
        public string? Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime? DateDone { get; set; }
    }
}
