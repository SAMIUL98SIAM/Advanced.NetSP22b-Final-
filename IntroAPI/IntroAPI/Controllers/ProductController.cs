using IntroAPI.Models.EF;
using IntroAPI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class ProductController : ApiController
    {
        protected Api1Entities db = new Api1Entities();

        [Route("api/product/names")]
        [HttpGet]
        public List<string> PNames()
        {
            var data = (from e in db.Products select e.Name).ToList();
            return data;
        }

        [Route("api/product/names/{id}")]
        [HttpGet]
        public string PNames(int id)
        {
            var data = (from e in db.Products where e.Id == id select e.Name).FirstOrDefault();
            return data;
        }

        public List<ProductModel> Get()
        {
            var data = new List<ProductModel>();
            foreach (var item in db.Products)
            {
                /*var p = new ProductModel() { Id = item.Id};*/
                data.Add(new ProductModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = (double)item.Price
                });
            }

            return data;
        }

        public void Post(ProductModel product)
        {

        }
    }
}
