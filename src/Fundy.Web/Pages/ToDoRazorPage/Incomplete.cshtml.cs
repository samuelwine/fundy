using Fundy.Core.Entities;
using Fundy.Core.Specifications;
using Fundy.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fundy.Web.Pages.ToDoRazorPage
{
    public class IncompleteModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IncompleteModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            var spec = new IncompleteItemsSpecification();

            ToDoItems = await _repository.ListAsync(spec);
        }
    }
}
