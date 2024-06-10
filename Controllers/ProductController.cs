using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPIPRoject.Models;
using ProductAPIPRoject.Repository;

namespace ProductAPIPRoject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpPost]
        public Product PostProduct(Product product) 
        {
            return _productService.PostProduct(product);
        }


    }
}
