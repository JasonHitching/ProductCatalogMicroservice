using System;
using ProductCatalog.Models;

namespace ProductCatalog.Repositories;

public class ProductRepository : IProductRepository
{
    private static readonly List<Product> Products =
    [
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sample Product 1",
            Description = "This is a sample product.",
            Price = 19.99m,
            StockQuantity = 100,
            Category = "Electronics"
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sample Product 2",
            Description = "This is another sample product.",
            Price = 29.99m,
            StockQuantity = 50,
            Category = "Books"
        }
    ];

    /// <summary>
    /// Fetch all existing products
    /// </summary>
    /// <returns>All product data</returns>
    public IEnumerable<Product> GetAllProducts()
    {
        return Products;
    }

    /// <summary>
    /// Fetch a product by its ID
    /// </summary>
    /// <param name="id">Product ID to search by</param>
    /// <returns>Matched product</returns>
    public Product? GetProductById(Guid id)
    {
        // IDs are unique, return the first match.
        return Products.FirstOrDefault(p => p.Id == id);
    }
}
