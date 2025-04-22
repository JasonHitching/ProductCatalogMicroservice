using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using ProductCatalog.Repositories;

namespace ProductCatalog.Controllers;

public class ProductsController : ControllerBase
{
    private readonly ProductRepository repository;

    public ProductsController()
    {
        repository = new ProductRepository();
    }

    [HttpGet]
    [Route("/products/")]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        var products = repository.GetAllProducts();

        if (products is null || !products.Any())
        {
            return NotFound("No products were found.");
        }

        return Ok(products);
    }
}
