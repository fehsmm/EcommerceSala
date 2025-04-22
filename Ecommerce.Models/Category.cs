namespace Ecommerce.Data
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
