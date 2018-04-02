using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Paari.Data.Repository;
using Paari.Entietes.Product;
using Paari.Entietes.ViewModel;

namespace Pari.Api.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/values
        [HttpGet]
        public List<ProductViewModel> GetAllProductsList()
        {
            var repo = new ProductRepo();
            List<ProductViewModel> productsList = repo.GetAllProductsList().ToList();
            return productsList;
        }

        // GET api/values/5
        [HttpGet]
        public ProductViewModel GetProduct(Guid id)
        {
            var repo = new ProductRepo();
            ProductViewModel product = repo.GetProduct(id);
            return product;
        }

        // POST api/values
        [HttpPost]
        public string Post(ProductViewModel newProudct)
        {
            var repo = new ProductRepo();
            Guid? productid = repo.SaveNewProduct(newProudct);
            if (productid!=null)
            {
                return productid.ToString();
            }
            return "Nie udało się utworzyć produktu spróbuj jeszcze raz";
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
