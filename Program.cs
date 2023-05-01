using Microsoft.EntityFrameworkCore;
using Recepcion.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RecepcionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecepcionContext") ?? throw new InvalidOperationException("Connection string 'RecepcionContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
