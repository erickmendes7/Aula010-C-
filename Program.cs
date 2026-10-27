using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using aula10.data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
  options.UseSqlite(
    "Data Source = BolsasDoCurso.db"
  );      
    } 
);


var app = builder.Build();

app.MapGet("/cursos",(AppDbContext context) =>
{
return context.Bolsistas.ToList();
});

app.MapPost("/cursos",(AppDbContext context, Curso curso) =>
{
context.Bolsa.Add(aluno);
context.SaveChanges();
return Results.Created(
$"/alunos/{aluno.Id}",
aluno);
});

app.Run();
