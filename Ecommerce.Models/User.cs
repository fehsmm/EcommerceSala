namespace Ecommerce.Data
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Guid AddressId { get; set; }
        public string NIF { get; set; }
        public DateTime Birthdate { get; set; }
    }


}
