using EcommerceSala.Models;
using EcommerceSala.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSala.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public Product GetById(Guid id)
        {
            ProductService p = new ProductService();

            var result = p.GetById(id);

            return result;
        }

        [HttpPut]
        public Product Update(Product product)
        {
            ProductService p = new ProductService();

            var result = p.Update(product);

            return result;
        }

        [HttpPost]
        public Product Create(Product product)
        {
            ProductService p = new ProductService();

            var result = p.Create(product);

            return result;
        }

        // TODO:

        // Create the rest of the endpoints
        // PUT - Update
        // POST - Add
        // DELETE - Delete (update of IsActive)


        // Create a link to the Service of each endpoint
        // var result = p.GetById(Guid.NewGuid());


        // Create the next controller
        // Category
        // Subcategory
        // ....

    }
}
