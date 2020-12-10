using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundy.Web.ApiModels
{
    public class DonorDetailsDTO
    {
        public DonorDTO Donor { get; set; } 
        public List<AddressDTO> Addresses { get; set; }
    }
}
