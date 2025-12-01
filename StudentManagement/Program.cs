using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Data;
using StudentManagement.StudentManagement.Core.Services;

var builder = WebApplication.CreateBuilder(args);

//Đăng ký automapper
builder.Services.AddAutoMapper(typeof(Program));

//Đăng ký kết nối SqlServer
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Đăng kí service student
builder.Services.AddScoped<StudentService, StudentService>();

//Đăng kí service user
builder.Services.AddScoped<UserService, UserService>();

Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
