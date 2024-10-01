using FurniFusion_E_Commerce_.Dtos.ProductManager;
using FurniFusion_E_Commerce_.Models;
using FurniFusion_E_Commerce_.Queries;

namespace FurniFusion_E_Commerce_.Interfaces
{
    public interface IProductManagerRepository
    {
        Task<List<Product>> GetAllProductsAsync(ProductFilter filter);
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Product> CreateProductAsync(CreateProductDto productDto, string creatorId);
        Task<Product> UpdateProductAsync(UpdateProductDto productDto);
        Task<Category> CreateCategoryAsync(CreateCategoryDto categoryDto, string creatorId);
        Task<Category> UpdateCategoryAsync(UpdateCategoryDto categoryDto, string updatorId);
        Task DeleteProductAsync(int id);
        Task DeleteCategoryAsync(int id);
    }
}
