﻿using Microsoft.EntityFrameworkCore;
using ProductAPIPRoject.Models;
namespace ProductAPIPRoject.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; } = default;
    }
}
