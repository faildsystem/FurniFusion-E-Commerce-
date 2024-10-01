using FurniFusion_E_Commerce_.Dtos.ProductManager;
using FurniFusion_E_Commerce_.Interfaces;
using FurniFusion_E_Commerce_.Models;
using FurniFusion_E_Commerce_.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FurniFusion_E_Commerce_.Controllers
{
    [Authorize(Roles = "superAdmin, productManager")]
    [ApiController]
    [Route(("api/[controller]"))]
    public class ProductManagerController : ControllerBase
    {
        private readonly IProductManagerRepository _productManagerRepository;
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public ProductManagerController(UserManager<User> userManager, ITokenService tokenService, IProductManagerRepository productManagerRepository)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _productManagerRepository = productManagerRepository;
        }

        [HttpGet("getProducts")]
        public async Task<IActionResult> GetProducts([FromQuery] ProductFilter filter)
        {
            var Products = await _productManagerRepository.GetAllAsync(filter);
            var TotalProducts = Products.Count;



            return Ok(new {TotalProducts, Products});
        }

        [HttpPost("createProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto productDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var creatorId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var product = await _productManagerRepository.CreateProductAsync(productDto, creatorId);

                return Ok(product);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("deleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _productManagerRepository.DeleteAsync(id);
                return Ok(new {message = "Product deleted"});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
