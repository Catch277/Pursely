using Microsoft.EntityFrameworkCore;
using SportSln.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// 2. Database Context & Repositories
builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();

// 3. Session & Cart 
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor(); // 
builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));

var app = builder.Build();

// 4. Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseSession(); 

// 5. Routing
app.MapControllerRoute("catpage", "{category}/Page{productPage:int}",
    new { Controller = "Home", action = "Index" });

app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("pagination", "Products/Page{productPage}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapDefaultControllerRoute();
app.MapRazorPages();

// 6. Seed Data & Run
SeedData.EnsurePopulated(app);
app.Run();