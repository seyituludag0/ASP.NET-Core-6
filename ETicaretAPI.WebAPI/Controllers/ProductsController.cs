using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductService productService, IProductWriteRepository productWriteRepository)
        {
            _productService = productService;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet("getProducts")]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("/add")]
        public async void Add()
        {
            await _productWriteRepository.ListAddRangeAsync(new()
            {
                new() { Id = 1, Name = "Curved Monitör", Stock = 250, Price = 4000, CreatedTime = DateTime.UtcNow },
                new() { Id = 2, Name = "Laptop", Stock = 50, Price = 5000, CreatedTime = DateTime.UtcNow },
            });
            await _productWriteRepository.SaveAsync();
        }

        //[HttpPost("/add")]
        //public async Task Add(Product product)
        //{
        //    await _productWriteRepository.AddAsync(product);
        //    await _productWriteRepository.SaveAsync();
        //}
    }
}
