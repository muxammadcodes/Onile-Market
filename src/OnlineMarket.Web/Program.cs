using Microsoft.EntityFrameworkCore;
using OnlineMarket.DataAccess.Context;
using OnlineMarket.DataAccess.IRepositories;
using OnlineMarket.DataAccess.Repositories;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Service.Interfaces;
using OnlineMarket.Service.Mappers;
using OnlineMarket.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddDbContext<OnlineMarketDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MapperProfile));

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
