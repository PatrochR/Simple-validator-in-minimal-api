global using Microsoft.EntityFrameworkCore;
global using BookApi.Models;
global using BookApi.Data;
using FluentValidation;
using BookApi.Validators;
using BookApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlite("Data source=BookDb");
});
builder.Services.AddScoped<IValidator<BookDto> , BookValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.MapBook();

//Run the application 

app.Run();

