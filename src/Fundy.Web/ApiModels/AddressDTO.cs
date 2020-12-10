using System.ComponentModel.DataAnnotations;

namespace Fundy.Web.ApiModels
{
    public class AddressDTO
    {
        public string AddressType { get; set; }
        [Required]
        public string Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        [Required]
        public string City { get; set; }
        public string? County_Province { get; set; }
        [Required]
        public string Postcode_Zip { get; set; }
        [Required]
        public string Country { get; set; }

        public AddressDTO(string addressType, string line1, string city, string postcode_zip, string country)
        {
            AddressType = addressType;
            Line1 = line1;
            City = city;
            Postcode_Zip = postcode_zip;
            Country = country;
        }
    }
}
