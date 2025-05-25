using EcommerseWebApi;
using EcommerseWebApi.Model.Implementation;
using EcommerseWebApi.Model.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IProduct, Imp_Product>();



var app = builder.Build();
app.UseAuthorization();



app.MapControllers();

app.UseCors(w => w.WithOrigins("http://localhost:5194").AllowAnyHeader().AllowAnyMethod());


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
