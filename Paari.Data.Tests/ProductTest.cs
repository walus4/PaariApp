using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paari.Data.Repository;
using Paari.Entietes.Product;
using Paari.Entietes.ViewModel;

namespace Paari.Data.Tests
{
    [TestClass]
    public class ProductTest
    {private Guid idnewProduct=new Guid();
        [TestMethod]
        public void SeveProduuctAndReturnId()
        {
            using (var db = new ProductDbContext())
            {
                var repo = new ProductRepo();
                ProductViewModel prooduct= new ProductViewModel
                {
                    Name = "Test",
                    Price = (decimal) 7.77
                };
                Guid? id = repo.SaveNewProduct(prooduct);
                idnewProduct = (Guid) id;
                Assert.AreNotEqual("f9cc61f1 - 820b - 4a6f - a27c - 06fece019668", id);
            }
        }

        [TestMethod]
        public void GetProductList()
        {
            using (var db = new ProductDbContext())
            {
                var repo = new ProductRepo();
                var list = repo.GetAllProductsList();

                Assert.AreNotEqual(null, list);
            }
        }

        [TestMethod]
        public void GetProduct()
        {

            using (var db = new ProductDbContext())
            {
                var repo = new ProductRepo();
                var list = repo.GetProduct(idnewProduct);
                Assert.AreNotEqual(null, list);
            }
        }

        [TestMethod]
        public void UpdateProduct()
        {

            using (var db = new ProductDbContext())
            {
                ProductViewModel prooduct = new ProductViewModel
                {Id = idnewProduct,
                    Name = "Tests",
                    Price = (decimal)7.78
                };
                var repo = new ProductRepo();
                repo.UpdateProduct(prooduct);
                var list = repo.GetProduct(idnewProduct);
                Assert.AreNotEqual("Test", list.Name);
                Assert.AreNotEqual(7.77, list.Price);
            }
        }

        [TestMethod]
        public void deleteProduct()
        {

            using (var db = new ProductDbContext())
            {
                var repo = new ProductRepo();
                repo.DeleteProduct(idnewProduct);
                var list = repo.GetProduct(idnewProduct);
                Assert.AreEqual(null,list);

            }
        }

    }
}
