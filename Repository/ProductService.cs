using ProductAPIPRoject.Data;
using ProductAPIPRoject.Models;

namespace ProductAPIPRoject.Repository
{
    public class ProductService : IProductService
    {
        ProductContext _context;
        public ProductService(ProductContext context)
        {
           _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Product PostProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChangesAsync();
            return product;
        }
    }
}
