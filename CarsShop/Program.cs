using CarsShop.App_Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//memoryDb
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseInMemoryDatabase("MemoryAccounts");
}, ServiceLifetime.Scoped);

builder.Services.AddControllersWithViews();
var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
