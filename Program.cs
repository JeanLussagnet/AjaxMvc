using AjaxMvc.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());
app.UseStaticFiles();

app.Run();
