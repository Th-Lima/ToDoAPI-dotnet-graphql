using Microsoft.EntityFrameworkCore;
using ToDoAPI.src.Database.Domain;


namespace ToDoAPI.src.Database
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Tasks { get; set; }
    }
}
