namespace Ecommerce.Data
{
    public class Rating : BaseModel
    {
        public string Description { get; set; }
        public int Stars { get; set; }
        public Guid UserId { get; set; }
    }

    
}
