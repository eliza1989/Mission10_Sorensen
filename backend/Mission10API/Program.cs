//Bring in the necessary packages and connect and bring in necessary services
using Microsoft.EntityFrameworkCore;
using Mission10API.Data;

//Build the application
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

//Connect and configure connection string
builder.Services.AddDbContext<BowlingContext>( options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlerConnection"])
);

//Connect Repositories
builder.Services.AddScoped<IBowlingRepository, EFBowlingRepository>();

//Build app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Allow data from the listed url/localhost
app.UseCors(p => p.WithOrigins("http://localhost:3000"));


//Settings to allow app to run
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
