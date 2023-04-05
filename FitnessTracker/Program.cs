using FitnessTracker.Bll.Implementations;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
  .AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<FitnessTrackerDbContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddScoped<IAchievmentInfoRepository, AchievementInfoRepository>();
builder.Services.AddScoped<IExerciseRepository, ExerciseRepository>();
builder.Services.AddScoped<IWorkOutRepository, WorkOutRepository>();
builder.Services.AddScoped<IUserGoalRepository, UserGoalRepository>();

builder.Services.AddScoped<IWorkOutHistoryRepository, WorkOutHistoryRepository>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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

