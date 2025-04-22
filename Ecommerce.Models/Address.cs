namespace Ecommerce.Data
{
    public class Address : BaseModel
    {
        public string Number { get; set; }
        public string Details { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }


}
