using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using Paari.Entietes.Product;
using Paari.Entietes.ViewModel;

namespace Common.Validation
{
    public class ProductValidation : ValidationAttribute
    {
        public Product ValidateProduct(ProductViewModel product)
        {
            if (product!=null)
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
    }
}