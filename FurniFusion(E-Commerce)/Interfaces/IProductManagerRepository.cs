using FurniFusion_E_Commerce_.Dtos.ProductManager;
using FurniFusion_E_Commerce_.Models;
using FurniFusion_E_Commerce_.Queries;

namespace FurniFusion_E_Commerce_.Interfaces
{
    public interface IProductManagerRepository
    {
        Task<List<Product>> GetAllAsync(ProductFilter filter);
        Task<Product> CreateProductAsync(CreateProductDto productDto, string creatorId);
        Task DeleteAsync(int id);
        //Task<Product> UpdateAsync(Product product);
    }
}
