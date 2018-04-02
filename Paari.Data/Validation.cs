using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paari.Entietes.Product;
using Paari.Entietes.ViewModel;

namespace Paari.Data
{
    public class Validation
    {

        public static Product ValidateProduct(ProductViewModel product)
        {
            if (product != null)
            {
                if (String.IsNullOrEmpty(product.Name) &&
                    product.Name.Length <= 100)
                {
                    if (product.Price != 0)
                    {
                        Product dbProduct = new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = product.Name,
                            Price = product.Price
                        };
                        return dbProduct;
                    }
                }
            }

            return null;
        }

        public static Product ValidationEditProduct(ProductViewModel product)
        {
            if (String.IsNullOrEmpty(product.Name) &&
                product.Name.Length <= 100)
            {
                if (product.Price != 0)
                {
                    Product editProduct = new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = product.Name,
                        Price = product.Price
                    };
                    return editProduct;
                }
            }
            return null;
        }
    }
}