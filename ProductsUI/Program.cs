using ProductsUI.Hubs;
using ProductsUI.MiddlewareExtensions;
using ProductsUI.SubscribeTableDependencies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
builder.Services.AddSingleton<DashboardHub>();
builder.Services.AddSingleton<SubscribeProductTableDependency>();
var app = builder.Build();
var connectionString = app.Configuration.GetConnectionString("DefaultConnection");
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapHub<DashboardHub>("/dashboardHub");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
app.UseSqlTableDependency<SubscribeProductTableDependency>(connectionString);
app.Run();
