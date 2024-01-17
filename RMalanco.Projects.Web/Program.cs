using Microsoft.Extensions.DependencyInjection;
using RMalanco.Projects.Service.Settings;

var builder = WebApplication.CreateBuilder(args);

// Configuración para acceder a los secretos
builder.Configuration.AddUserSecrets<Program>();

// Conexion a la base de datos 
builder.Services.AddDbContext(builder.Configuration);

// Servicios
builder.Services.AddServices();

// Sesiones
builder.Services.AddSessions();

// Autenticación
builder.Services.AddAuthenticationSettings(builder.Configuration);

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

app.UseSession();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Projects}/{controller=Home}/{action=Index}/{id?}");

app.Run();
