using ExciteCupClassic.Business.Contracts;
using ExciteCupClassic.Business.Services;
using ExciteCupClassic.Database.ExciteCupDbContext;
using ExciteCupClassic.Models.MappingProfile;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ExciteCupConnection");

builder.Services.AddDbContext<ExciteCupClassicDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(typeof(ExciteCupClassicProfile));

// Add services to the container.
builder.Services.AddScoped<ICompetitionService, CompetitionService>();

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
