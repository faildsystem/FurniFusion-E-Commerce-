using FurniFusion_E_Commerce_.Data;
using FurniFusion_E_Commerce_.Dtos.ProductManager;
using FurniFusion_E_Commerce_.Dtos.SuperAdmin;
using FurniFusion_E_Commerce_.Interfaces;
using FurniFusion_E_Commerce_.Models;
using FurniFusion_E_Commerce_.Queries;
using Microsoft.EntityFrameworkCore;

namespace FurniFusion_E_Commerce_.Repository
{
    public class ProductManagerRepository : IProductManagerRepository
    {
        private readonly FurniFusionDbContext _context;

        public ProductManagerRepository(FurniFusionDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProductAsync(CreateProductDto productDto, string creatorId)
        {
            var product = new Product
            {
                ProductName = productDto.ProductName,
                ImageUrls = productDto.ImageUrls,
                Dimensions = productDto.Dimensions,
                Price = productDto.Price,
                StockQuantity = productDto.StockQuantity,
                IsAvailable = productDto.IsAvailable,
                Weight = productDto.Weight,
                Color = productDto.Color,
                Description = productDto.Description,
                CategoryId = productDto.CategoryId,
                CreatorId = creatorId
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync(ProductFilter filter)
        {
            var products = _context.Products.AsQueryable();

            if (filter.Id > 0)
            {
                products = products.Where(x => x.ProductId == filter.Id);
            }

            if (!string.IsNullOrEmpty(filter.Name))
            {
                products = products.Where(x => x.ProductName!.Contains(filter.Name));
            }

            if (filter.Price.HasValue)
            {
                products = products.Where(x => x.Price == filter.Price);
            }

            if (filter.StockQuantity.HasValue)
            {
                products = products.Where(x => x.StockQuantity == filter.StockQuantity);
            }

            if (filter.IsAvailable.HasValue)
            {
                products = products.Where(x => x.IsAvailable == filter.IsAvailable);
            }

            if (filter.Weight.HasValue)
            {
                products = products.Where(x => x.Weight == filter.Weight);
            }

            if (!string.IsNullOrEmpty(filter.Color))
            {
                products = products.Where(x => x.Color!.Contains(filter.Color));
            }

            if (!string.IsNullOrEmpty(filter.Description))
            {
                products = products.Where(x => x.Description!.Contains(filter.Description));
            }

            if (filter.CategoryId.HasValue)
            {
                products = products.Where(x => x.CategoryId == filter.CategoryId);
            }

            if (!string.IsNullOrEmpty(filter.CreatorId))
            {
                products = products.Where(x => x.CreatorId == filter.CreatorId);
            }

            var skipNumber = (filter.PageNumber - 1) * filter.PageSize;

            var productsList = await products.Skip(skipNumber).Take(filter.PageSize).ToListAsync();

            return await products.Skip(skipNumber).Take(filter.PageSize).ToListAsync();
        }
    }
}
