using Address_Book_Api.Application.Models;
using Address_Book_Api.Infrastructure;
using Address_Book_Api.Infrastructure.Data;
using Address_Book_Api.Middleware;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Address Book Api",
        Version = "v1" ,
        Description="This Api allows you to get list of address books",
        Contact = new OpenApiContact
        {
            Name="Tsireledzo",
            Email="rambuwanitsireledzo@gmail.com"
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddInfrastructure();

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext().CreateLogger();

builder.Host.UseSerilog();


var allowedOrigins = builder.Configuration
                       .GetSection("Cors:AllowedOrigins")
                       .Get<string[]>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins(allowedOrigins ?? []));
});

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AddressBookContext>();
    db.Database.EnsureCreated();
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Address Book Api"));
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
