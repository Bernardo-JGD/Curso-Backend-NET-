using Microsoft.EntityFrameworkCore;
using Proyecto_Escuela_v1.Context;
using Proyecto_Escuela_v1.DTOs;
using Proyecto_Escuela_v1.Models;
using Proyecto_Escuela_v1.Repository;
using Proyecto_Escuela_v1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Repository
builder.Services.AddScoped<IRepository<Estado>, EstadoRepository>();
builder.Services.AddScoped<IRepository<Estudiante>, EstudianteRepository>();
builder.Services.AddScoped<IRepository<Horario>, HorarioRepository>();
builder.Services.AddScoped<IRepository<Imparte>, ImparteRepository>();
builder.Services.AddScoped<IRepository<Maestro>, MaestroRepository>();
builder.Services.AddScoped<IRepository<Materia>, MateriaRepository>();
builder.Services.AddScoped<IRepository<MateriaEstudiante>, MateriaEstudianteRepository>();
builder.Services.AddScoped<IRepository<Ubicacion>, UbicacionRepository>();

//ICommonService
builder.Services.AddScoped<ICommonService<EstadoDTO, EstadoInsertDTO, EstadoUpdateDTO>, EstadoService>();
builder.Services.AddScoped<ICommonService<EstudianteDTO, EstudianteInsertDTO, EstudianteUpdateDTO>, EstudianteService>();

//Entity Framework
builder.Services.AddDbContext<EscuelaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EscuelaConnection"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
