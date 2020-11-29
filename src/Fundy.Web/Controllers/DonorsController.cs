using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundy.Core.Entities;
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
            ///test azure ceploy
            return View(donorList);
        }
    }
}
