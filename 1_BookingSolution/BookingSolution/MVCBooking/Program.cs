using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCBooking.Data;
using MVCBooking.PasswordValidators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("BookingDbConn");
builder.Services.AddDbContext<BookingDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddIdentity<IdentityUser, IdentityRole>(passwordOptions =>
{
    passwordOptions.Password.RequireNonAlphanumeric = false;
    passwordOptions.Password.RequireUppercase = false;
    passwordOptions.Password.RequireLowercase = false;
    passwordOptions.Password.RequiredLength = 4;
}).AddEntityFrameworkStores<BookingDbContext>()
.AddPasswordValidator<CapitalPasswordValidator>()
.AddPasswordValidator<NumberPasswoordValidator>()
.AddPasswordValidator<UserPasswoordValidator>();



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
