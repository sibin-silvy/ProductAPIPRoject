using Microsoft.EntityFrameworkCore;
using ProductAPIPRoject.Data;
using ProductAPIPRoject.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ProductContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnectionString")??
    throw new InvalidOperationException("Connecton string not found")
    ));

builder.Services.AddControllers();

builder.Services.AddScoped<IProductService,ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
