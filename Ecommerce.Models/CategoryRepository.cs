using Ecommerce.Models;
using LeanGoHub.Data.Repository;

namespace Ecommerce.Data
{

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(LeanGoHubDbContext context, AppSettings appSettings)
           : base(context, appSettings) { }
    }
}
