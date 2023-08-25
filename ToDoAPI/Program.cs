var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
