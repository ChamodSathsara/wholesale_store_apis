using Microsoft.EntityFrameworkCore;
using wholesale_store.Data;
using wholesale_store.Servicess;
using wholesale_store.Servicess.Repositories;
using wholesale_store.Servicess.Servicess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ITasksRepository,TaskService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //update
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
