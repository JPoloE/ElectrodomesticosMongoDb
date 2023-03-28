using AutoMapper.Data;
using ElectrodomesticosMongoDb.AutoMapper;
using Infrastructura.CasosdeUso.Interfaces;
using Infrastructura.CasosdeUso;
using Dominio.CasosdeUso.Gateway;
using Dominio.CasosdeUso.CasosdeUso;
using Dominio.CasosdeUso.Gateway.Repositorio;
using Infrastructura.CasosdeUso.ElectrodomesticoRepositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(config => config.AddDataReaderMapping(), typeof(ConfiguracionProfile));
builder.Services.AddSingleton<IContext>(provider => new Context(builder.Configuration.GetConnectionString("DefaultConnection"), "test"));

builder.Services.AddScoped<IElectrodomesticoCasodeUso, ElectrodomesticoCasodeUso>();
builder.Services.AddScoped<IElectrodomesticoRepositorio, ElectrodomesticoRepositorio>();


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
