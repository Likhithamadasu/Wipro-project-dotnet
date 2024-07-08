using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeInfo.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EmployeeInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeInfoContext") ?? throw new InvalidOperationException("Connection string 'EmployeeInfoContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
