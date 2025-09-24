using MoviesBlazor.Components;
using MoviesBlazor.Clients;

//Create a new instance of the WebApplication class
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// services are objects that are used to add functionality to the application
// such as NavigationManager, HttpClient etc.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//RazorComponents are a new feature in ASP.NET Core that allow you to build web applications using C# and HTML

var movieAppUrl = builder.Configuration["MovieApiUrl"] ?? throw new Exception("MovieApiUrl is not set");//get the URL of the movie app from the configuration file
// ?? is equivalent to "is null ?"
builder.Services.AddHttpClient<MoviesClient>(client => client.BaseAddress = new Uri(movieAppUrl)); //Add the HttpClient service to the container

var app = builder.Build(); //Build the application //creates an instance of the WebApplication class

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //redirects HTTP requests to HTTPS

app.UseStaticFiles(); // serves statis files such as images, CSS and JS in the wwwroot folder
app.UseAntiforgery(); // protects the app from cross-site request forgery (CSRF) attacks

app.MapRazorComponents<App>() // maps RazorComponents to the App component
    .AddInteractiveServerRenderMode();

app.Run(); // start the app
