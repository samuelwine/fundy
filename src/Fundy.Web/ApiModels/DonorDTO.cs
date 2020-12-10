using Fundy.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Fundy.Web.ApiModels
{
    public class DonorDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        public string? Title { get; set; }
       
        public DonorDTO(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public static DonorDTO FromDonor(Donor donor)
        {
            var donorDTO = new DonorDTO(donor.Id, donor.Name.FirstName, donor.Name.LastName)
            {
                Title = donor.Name.Title,
            };

            return donorDTO;
        }
    }
}
