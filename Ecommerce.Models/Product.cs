namespace Ecommerce.Data
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Guid WarehouseId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public Guid RatingId { get; set; }
        public int DeliveryTimeMin { get; set; }
        public int DeliveryTimeMax { get; set; }
        public double DeliveryFee { get; set; }
    }


}
