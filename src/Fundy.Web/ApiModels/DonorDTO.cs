using Fundy.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Fundy.Web.ApiModels
{
    public class DonorDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Title { get; set; }

        public DonorDTO(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static DonorDTO FromDonor(Donor donor)
        {
            return new DonorDTO(donor.Name.FirstName, donor.Name.LastName)
            {
                Title = donor.Name.Title,
            };
        }
    }
}
