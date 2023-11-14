using Microsoft.EntityFrameworkCore;
using Tarefas.Models;
using Tarefas.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurando a conexão com o banco de dados
var stringDeConexão = builder.Configuration.GetConnectionString("ConexaoMySQL");
builder.Services.AddDbContext<DataContext>(opt => opt.UseMySql(
    stringDeConexão,
    ServerVersion.Parse("10.4.28-MariaDB")
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
