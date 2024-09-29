using BackFecha.Identidades;
using BackFecha.Repositorio.Implementacion;
using BackFecha.Repositorio.Inferfaces;
using BackFecha.Servicio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<Fecha>();
builder.Services.AddScoped<IFechaRepositorio, FechaRepositorio>();
builder.Services.AddScoped<IManager, FechaManger>();


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
