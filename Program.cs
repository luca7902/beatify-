using Microsoft.EntityFrameworkCore;
using MusikPlayer.Data;
using MusikPlayer.Data.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // F�r MVC + Views
builder.Services.AddScoped<BeatService>();

builder.Services.AddDbContext<MusicDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Klassisches MVC Routing (f�r Views)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Music}/{action=Index}/{id?}");

// API Routing aktivieren (z.B. f�r /music/beats)
app.MapControllers();

app.Run();
