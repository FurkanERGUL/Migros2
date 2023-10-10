using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Migros.DAL.Abstract;
using Migros.DAL.Concrete;
using Migros.DAL.Contexts;
using Migros.DATA.Abstract;
using Migros.DATA.Concrete;
using Migros.Service.Abstract;
using Migros.Service.Concrete;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepo<>));
builder.Services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));

builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddScoped<IAppUserRepo, AppUserRepo>();
builder.Services.AddTransient<IAppUserService, AppUserService>();

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 3;

    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedAccount = false;

    options.User.RequireUniqueEmail = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders().AddRoles<IdentityRole>();

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
