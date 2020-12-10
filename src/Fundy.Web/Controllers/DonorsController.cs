using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundy.Core.Entities;
using Fundy.Core.Specifications;
using Fundy.SharedKernel.Interfaces;
using Fundy.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;


namespace Fundy.Web.Controllers
{
    public class DonorsController : Controller
    {
        private readonly IRepository _repository;

        public DonorsController(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var donorList = (await _repository.ListAsync<Donor>()).Select(DonorDTO.FromDonor).ToList();
            return View(donorList);
        }

        public async Task<IActionResult> Addresses(int selectedDonorId)
        {
            var selectedDonor = await _repository.GetByIdAsync<Donor>(selectedDonorId);
            var addresses = new List<AddressDTO>()
                {
                    new AddressDTO( "Home Address",
                                    selectedDonor.HomeAddress.Line1,
                                    selectedDonor.HomeAddress.City,
                                    selectedDonor.HomeAddress.Postcode_Zip,
                                    selectedDonor.HomeAddress.Country),
                    new AddressDTO( "Work Address",
                                    selectedDonor.WorkAddress.Line1,
                                    selectedDonor.WorkAddress.City,
                                    selectedDonor.WorkAddress.Postcode_Zip,
                                    selectedDonor.WorkAddress.Country)
                };
            var jsonAddresses = Json(addresses);
            return jsonAddresses;
        }

        public async Task<IActionResult> DonorDetails(int id)
        {
            var selectedDonor = await _repository.GetByIdAsync<Donor>(id);
            var donorDetailsModel = new DonorDetailsDTO
            {
                Donor = new DonorDTO(id, selectedDonor.Name.FirstName, selectedDonor.Name.LastName)
                { Title = selectedDonor.Name.Title },
                Addresses = new List<AddressDTO>
                                              {
                                                  new AddressDTO(   "Home Address",
                                                                    selectedDonor.HomeAddress.Line1,
                                                                    selectedDonor.HomeAddress.City,
                                                                    selectedDonor.HomeAddress.Postcode_Zip,
                                                                    selectedDonor.HomeAddress.Country),
                                                  new AddressDTO( "Work Address",
                                                                    selectedDonor.WorkAddress.Line1,
                                                                    selectedDonor.WorkAddress.City,
                                                                    selectedDonor.WorkAddress.Postcode_Zip,
                                                                    selectedDonor.WorkAddress.Country)
                                              }

            }; 
                                            
            return View(donorDetailsModel);
        }
    }
}
