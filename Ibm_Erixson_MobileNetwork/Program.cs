using Ibm_Erixson_MobileNetwork.DbConnect;
using Ibm_Erixson_MobileNetwork.Interfaces;
using Ibm_Erixson_MobileNetwork.Repositores;
using Ibm_Erixson_MobileNetwork.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRoomTypeRepositores, RoomTypeRepositores>();
builder.Services.AddScoped<IRoomTypeServices,RoomTypeServices>();
builder.Services.AddDbContext<HotelRoomContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
