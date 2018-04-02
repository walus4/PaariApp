using System.Collections.Generic;
using Paari.Entietes.Product;

namespace Paari.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Paari.Data.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Paari.Data.ProductDbContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "ko³o",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "but",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id =Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id =Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id =Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "¿arówka",
                    Price = (decimal) 75.55
                },
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
