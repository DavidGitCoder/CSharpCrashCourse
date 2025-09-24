using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using MoviesAPI.Data;
using MoviesAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

//Use connection string from appsettings.json - DEPENDENCY INJECTION
builder.Services.AddDbContext<MovieContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbCS")));

var app = builder.Build();

//Asynchronous method to seed data into our DB
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<MovieContext>();
        await context.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occured while migrating the DB: {ex.Message}");
    }
}

app.MapGet("/", () => "Hello World!");
app.MapMoviesEndpoints();

app.Run();

//Understanding REST API Principles:

//Representational State Transfer (REST) is an architectural style that uses HTTP methods and is stateless.
//Statelessness means each request from a client to server must contain all the information needed to understand and process the request.
//Resource-based: REST uses resources, which are identified by URIs (Uniform Resource Identifiers)
//HTTP Methods:

//CRUD
//GET: Retrieve data from the server
//POST: Send data to the server to create a new resource
//PUT: Update an existing resource or create a new resource if it doesn't exist
//DELETE: Remove a resource from the server
//PATCH: Apply partial modifications to a resource
//Status codes:

//2xx(Success): eg: 200 OK, 201 Created
//4xx (Client error): eg: 400 Bad Request, 401 Unauthorized, 404 not found
//5xx (Server Error=: eg: 500 Internal Server Error, 503 Service Unavailable
//URI Design

//Use nouns to represent resources, not verbs, eg: /users instead of /getUsers
//Utilize hierarchy in URIs to represent relationships. eg: /user/{userId}/ posts for posts by a specific user
//Avoid using query parameters to alter the state. Instead use them for filtering, sorting, and searching
//API Security

//Use HTTPS to ensure encrypted communication
//Implements authentication and authorization mechanisms, like OAuth, JWT (JSON Web Tokens) or API keys
//Validate and sanitize inputs to prevent SQL injections and cross site stitching (XSS)


