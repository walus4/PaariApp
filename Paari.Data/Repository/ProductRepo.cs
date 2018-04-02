using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paari.Entietes.Product;
using Paari.Entietes.ViewModel;
using Common.Validation;


namespace Paari.Data.Repository
{
    public class ProductRepo
    {

        public List<ProductViewModel> GetAllProductsList()
        {
            using (var db = new ProductDbContext())
            {
                var products = new List<Product>();
                products = db.Products.AsNoTracking().ToList();

                if (products != null && products.Any())
                {
                    List<ProductViewModel> productView = new List<ProductViewModel>();
                    foreach (var product in products)
                    {
                        productView.Add(new ProductViewModel
                        {
                            Name = product.Name,
                            Id = product.Id,
                            Price = product.Price
                        });
                    }
                    return productView;
                }
                return null;
            }
        }

        public ProductViewModel GetProduct(Guid productId)
        {
            using (var db = new ProductDbContext())
            {
                var product = new Product();
                product = db.Products.Find(productId);

                if (product != null)
                {
                    ProductViewModel productView = new ProductViewModel
                    {
                        Name = product.Name,
                        Id = product.Id,
                        Price = product.Price
                    };
                    ;
                    return productView;
                }
                return null;
            }

        }

        public bool DeleteProduct(Guid productId)
        {
            using (var db = new ProductDbContext())
            {
                var productToDelete = db.Products.Find(productId);
                if (productToDelete != null)
                {
                    try
                    {
                        db.Products.Remove(productToDelete);
                        db.SaveChanges();

                        return true;
                    }
                    catch (Exception )
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        public Guid? SaveNewProduct(ProductViewModel product)
        {
            Product productDb = Validation.ValidateProduct(product);
            if (productDb != null)
            {
                using (var db = new ProductDbContext())
                {
                    db.Products.Add(productDb);
                    db.SaveChanges();
                    return productDb.Id;
                }
            }
            return null;
        }

        public void UpdateProduct(ProductViewModel editProduct)
        {
            using (var db = new ProductDbContext())
            {
                if (db.Products.Any(w => w.Id == editProduct.Id))
                {
                    Product productDb = Validation.ValidationEditProduct(editProduct);
                    if (productDb != null)
                    {
                        {
                            db.Products.Add(productDb);
                            db.SaveChanges();
                        }
                    }
                }
            }

        }
    }
}