using System;
using ProductCatalog.Models;

namespace ProductCatalog.Repositories;

public interface IProductRepository
{
    /// <summary>
    /// Get a product by its ID
    /// </summary>
    /// <param name="id">The products ID</param>
    /// <returns>Matching product, if any.</returns>
    Product? GetProductById(Guid id);

    /// <summary>
    /// Get all products
    /// </summary>
    /// <returns>All existing products</returns>
    IEnumerable<Product> GetAllProducts();
}
