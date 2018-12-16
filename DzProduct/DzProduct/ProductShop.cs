namespace DzProduct
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductShop : DbContext
    {        
        public ProductShop()
            : base("name=ProductShop")
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Category { set; get; }

    }

}