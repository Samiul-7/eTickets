using eTickets;

var builder = WebApplication.CreateBuilder(args);

// Create the startup instance
var startup = new Startup(builder.Configuration);

// Configure services using Startup
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the pipeline using Startup
startup.Configure(app, app.Environment);

app.Run();