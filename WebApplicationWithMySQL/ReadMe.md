********************************************************************************************
This ReadMe file explains the logic of the c# project WebApplicationWithMySQL
********************************************************************************************
                             FOLDER => PROPERTIES launchSettings.JSON                                           
********************************************************************************************
This is a JSON configuration file for the launch settings of a web application.

The file contains the following elements:

"$schema": The URL to the JSON schema that this file adheres to.

"iisSettings": Settings related to Internet Information Services (IIS) Express, a lightweight web server for developers that allows testing and debugging web applications.

a. "windowsAuthentication": Specifies whether Windows authentication is enabled or not.

b. "anonymousAuthentication": Specifies whether anonymous authentication is enabled or not.

c. "iisExpress": Specifies the URL of the web application and the SSL port number.
"*"
"profiles": Specifies the profiles for launching the web application.

a. "WebApplicationWithMySQL": A profile with the name "WebApplicationWithMySQL". It includes the following settings:
 i. "commandName": Specifies the command to execute when launching the web application.
 
 ii. "dotnetRunMessages": Specifies whether to display the .NET Core runtime messages in the console.
 
 iii. "launchBrowser": Specifies whether to launch the default browser when launching the web application.
 
 iv. "launchUrl": Specifies the URL to launch in the browser.
 
 v. "applicationUrl": Specifies the URL(s) for the web application to listen on.
 "*"
 vi. "environmentVariables": Specifies the environment variables for the web application.
 
b. "IIS Express": A profile with the name "IIS Express". It includes the following settings:
 i. "commandName": Specifies the command to execute when launching the web application.
 
 ii. "launchBrowser": Specifies whether to launch the default browser when launching the web application.
 
 iii. "launchUrl": Specifies the URL to launch in the browser.
 
 iv. "environmentVariables": Specifies the environment variables for the web application.
Overall, this file provides the necessary configuration for launching and testing a web application in development mode, either with IIS Express or with the .NET Core runtime.
********************************************************************************************
                                FOLDER => CONTROLLERS
                                launchSettings
********************************************************************************************
This is a JSON configuration file for an ASP.NET Core web application.

The file contains the following elements:

1. "Logging": Specifies the logging settings for the web application.

a. "LogLevel": Specifies the minimum logging level for different categories of log messages. The following are the categories and their corresponding logging levels:
 i. "Default": The default logging level for messages that don't fall into any other category. In this case, the level is set to "Information", which means that messages with severity "Information", "Warning", "Error", and "Critical" will be logged.
 
 ii. "Microsoft.AspNetCore": The logging level for messages related to the ASP.NET Core framework itself. In this case, the level is set to "Warning", which means that messages with severity "Warning", "Error", and "Critical" will be logged.
 2. "AllowedHosts": Specifies the hosts that are allowed to access the web application. The wildcard means that any host is allowed to access the application.
Overall, this file provides the necessary configuration for logging and security settings for an ASP.NET Core web application.

********************************************************************************************
                                     Program.cs
********************************************************************************************
***var builder*** = WebApplication.CreateBuilder(args);": This line creates a new instance of a web application builder, which is used to configure and build the web application.

***builder.Services.AddControllers();***: This line adds the ASP.NET Core MVC controller services to the service container, which is used to register and resolve dependencies for the application.

***builder.Services.AddEndpointsApiExplorer();***: This line adds the endpoint routing and API explorer services to the service container, which are used to map and document the web API endpoints.

"builder.Services.AddSwaggerGen();": This line adds the Swagger generator service to the service container, which is used to generate Swagger/OpenAPI documentation for the web API endpoints.

"var app = builder.Build();": This line builds the web application from the configuration created by the builder.

"if (app.Environment.IsDevelopment()) { ... }": This block of code checks if the application is running in development mode, and if so, it configures Swagger and SwaggerUI middleware to generate and display Swagger documentation for the web API endpoints.

"app.UseHttpsRedirection();": This line adds middleware to redirect HTTP requests to HTTPS, if the application is configured to use HTTPS.

"app.UseAuthorization();": This line adds middleware to handle authentication and authorization of incoming requests.

"app.MapControllers();": This line adds middleware to handle incoming requests for the web API endpoints defined in the controllers.

"app.Run();": This line starts the web application and listens for incoming requests.
********************************************************************************************
                                    startup.cs
********************************************************************************************

********************************************************************************************

********************************************************************************************
create table justintest.Employee(
EmployeeId int auto_increment,
EmployeeName nvarchar(500),
Department nvarchar(500),
HireDate datetime,
PhotFileName nvarchar(500),
Primary key (EmployeeId)
);

insert into justintest.Employee(EmployeeName, Department, HireDate, PhotFileName) values ('Bob', 'IT', '2023-01-17','Profile pic.jpeg' );

 6:57
12:06 departmentContrller line 39 no definition for close cs1061