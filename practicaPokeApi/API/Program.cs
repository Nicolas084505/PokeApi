using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Interfaces.Reglas;
using DA.Dapper;
using Flujo;
using Reglas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();
builder.Services.AddScoped<IEntrenadorDA, PokemonDA>();
builder.Services.AddScoped<IPokemonDA, PokemonDA>();
builder.Services.AddScoped<IEquipoDA, PokemonDA>();
builder.Services.AddScoped<IEntrenadorXPokemonDA, PokemonDA>();
builder.Services.AddScoped<IEntrenadorFlujo,Flujos >();
builder.Services.AddScoped<IPokemonFlujo, Flujos>();
builder.Services.AddScoped<IEquipoFlujo, Flujos>();
//builder.Services.AddScoped<IEntrenadorXPokemonFlujo,Flujos>();
builder.Services.AddScoped<IEntrenadorReglas, EntrenadorReglas>();




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
