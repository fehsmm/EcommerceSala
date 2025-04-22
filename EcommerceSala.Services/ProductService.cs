using EcommerceSala.Models;

namespace EcommerceSala.Services
{
    public class ProductService
    {
        public Product GetById(Guid id)
        {
            var product = new Product();

            product.Id = id;
            product.Name = "Fulano";
            product.Price = 10;

            return product;
        }

        public Product Update(Product product)
        {
            product.Name = "Fulano2";
            product.Price = 1332;

            return product;
        }

        public Product Create(Product product)
        {
            product.Name = "Fulano2";
            product.Price = 1332;

            return product;
        }
    }
}
