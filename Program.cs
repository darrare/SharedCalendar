using Microsoft.EntityFrameworkCore;
using Npgsql;
using SharedCalendar.Components;
using SharedCalendar.Data;
using SharedCalendar.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", false);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.MapHub<CalendarHub>("/calendarHub");

app.Run();
