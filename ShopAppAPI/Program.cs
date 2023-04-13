using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopAppAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ShopAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopAppDbContext") ?? throw new InvalidOperationException("Connection string 'ShopAppDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();  

app.UseAuthorization();

app.MapControllers();

app.Run();
