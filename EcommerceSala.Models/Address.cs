using System.ComponentModel.DataAnnotations;

namespace EcommerceSala.Models
{
    public class Address : BaseModel
    {
        [MaxLength(10)]
        public string Number { get; set; }
        [MaxLength(20)]
        public string Details { get; set; }
        [MaxLength(50)]
        public string Street { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
    }
}
