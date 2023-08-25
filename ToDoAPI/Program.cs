using Microsoft.EntityFrameworkCore;
using ToDoAPI.src.Database;
using ToDoAPI.src.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Repositories
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

//Database
builder.Services.AddDbContext<TodoContext>(option => option.UseInMemoryDatabase("TodoDatabase"));

//HotChocolate
builder.Services.AddGraphQLServer();

var app = builder.Build();

app
.UseRouting()
.UseEndpoints(endpoints => 
{
    endpoints.MapGraphQL();
    
});


app.Run();
