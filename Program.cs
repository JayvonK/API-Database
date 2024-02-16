using API_Database.Data;
using API_Database.Services.Students;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // Creates the builder object which is used to configure and set up the web application

// builder.Services - adds features to the services container
// Think of the services container as a container for all the stuff our web app might need

// The first builder is accessing DbContext, the background data for our Database, and our DataContext file to set the Connection String
// The second builder is accessing our web apps configuration settings, or appsettings.json, and getting our connection string
// Leting our DataContext file know where our Database is
builder.Services.AddDbContext<DataContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection"))
);

builder.Services.AddControllers(); // Adds controllers to the services container - tells the application that it will use Controllers to handle HTTP requests
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle - More Code details here
builder.Services.AddEndpointsApiExplorer(); // Adds API Explorer to the services container - helps generate information about the API, such as the available endpoints and their documentation
builder.Services.AddSwaggerGen(); // Adds Swagger generation to the services container - allows us to use Swagger
builder.Services.AddScoped<IStudentService, StudentService>(); // Maps or connects the Interface to the Student Service

var app = builder.Build(); // builds the web app using the config provided by the builder

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // checks if the application is running in the development environment 
{
    // If it is, it enables Swagger and Swagger UI
    // This means that when the application is running locally, you can access the Swagger UI to explore and test your API
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection(); // Often used to enforce secure connections - commented out because I was getting a warning in the terminal when running :(

app.UseAuthorization(); // Configures the web app to use authorization, which means the web app should check for authorization before processing http requests - we will be getting to this later

app.MapControllers(); // Maps the Controllers to the web apps request pipeline. It tells the application to use the Controllers to handle incoming HTTP requests.

app.Run(); // Starts the application, causing it to listen for incoming HTTP requests and handle them based on the configured controllers
