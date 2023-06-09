using BuildComp_Database.Controllers;
using BuildComp_Database.Services;
using BuildComp_Database.Services.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<WebscraperService>();

var connectionString = builder.Configuration.GetConnectionString("BuildCompString");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddCors(options => {
    options.AddPolicy("BuildCompPolicy", 
    builder => {
        builder.WithOrigins("http://localhost:3000", "https://buildcomp.azurewebsites.net","https://buildcompfinal.azurewebsites.net")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("BuildCompPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();