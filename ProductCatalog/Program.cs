using ProductCatalog.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers(); // Add this to enable controllers
builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Register the repository
builder.Services.AddOpenApi(); // OpenAPI/Swagger setup

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

