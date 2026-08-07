using DotNetEnv;
using FureverHome.Data;
using FureverHome.Models;
using FureverHome.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FureverHomeContext>(options =>
    options.UseSqlServer(
        Environment.GetEnvironmentVariable("DB_CONNECTION")
        // builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services
    .AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<FureverHomeContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<ShelterService>();
builder.Services.AddScoped<PetService>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
