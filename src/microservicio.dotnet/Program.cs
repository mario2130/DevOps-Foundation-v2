using Microsoft.OpenApi.Models;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//logger
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
builder.Host.UseNLog();

//swagger
builder.Services.AddSwaggerGen(
            c =>
            {
                c.SwaggerDoc("v1",
                   new OpenApiInfo
                   {
                       Title = "microservicio.dotnet API - V1",
                       Version = "v1"
                   }
                );

                var filePathApi = Path.Combine(System.AppContext.BaseDirectory, "microservicio.dotnet.xml");
                c.IncludeXmlComments(filePathApi);

            }
        );

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(); 

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
