namespace Ecommerce.Data
{
    public class Checkout : BaseModel
    {
        public Guid PaymentMethodId { get; set; }
        public bool IsPaid { get; set; }
    }


}
