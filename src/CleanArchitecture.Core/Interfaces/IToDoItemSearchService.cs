using Ardalis.Result;
using Fundy.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fundy.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync();
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(string searchString);
    }
}
