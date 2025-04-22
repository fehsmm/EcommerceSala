namespace EcommerceSala.Models
{
    public class Checkout : BaseModel
    {
        public Guid PaymentMethodId { get; set; }
        public bool IsPaid { get; set; }
    }
}
