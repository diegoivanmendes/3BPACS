using _3BPACS.Domain.Interfaces;
using _3BPACS.Common.Interfaces;
using _3BPACS.Infrastructure.Repository;
using _3BPACS.Repository;
using _3BPACS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(_3BPACS.Common.MappingProfile).Assembly);

// Register your services

// Em Program.cs ou Startup.cs
builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<IExamOrderRepository, ExamOrderRepository>();
builder.Services.AddTransient<_3BPACS.Domain.Services.ExamOrderDomainService>();
builder.Services.AddTransient<_3BPACS.Application.ExamOrderAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
