using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<Product> CreateAsync(Product category);
        Task<Product> UpdateAsync(Product category);
        Task<Product> RemoveAsync(Product category);
    }
}