using sessionTpDIP.Filters;
using sessionTpDIP.Mappers;
using sessionTpDIP.Persisters;
using sessionTpDIP.Repositories;
using sessionTpDIP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddScoped<TodoMapper>();
builder.Services.AddScoped<SessionRepository>();
builder.Services.AddScoped<ITodoService,TodoService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IThemeService, ThemeService>();
builder.Services.AddScoped<CookieRepository>();
builder.Services.AddScoped<UserMapper>();
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(typeof(ThemeFilter));
    options.Filters.Add(typeof(LogsFilter));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
