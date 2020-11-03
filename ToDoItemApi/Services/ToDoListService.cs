using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoItemApi.Models;
using ToDoItemApi.Models.Configuration;

namespace ToDoItemApi.Services
{
    public class ToDoListService : IToDoListService
    {
        private readonly GetOptions _getOptions = new GetOptions();

        public ToDoListService(IConfiguration configuration)
        {
            configuration.Bind("GetOptions", _getOptions);
        }

        public List<ToDoItem> GetToDoItems()
        {
            return new List<ToDoItem>
            {
                new ToDoItem { Id = 1, Name = "name1", IsComplete = true },
                new ToDoItem { Id = 2, Name = "name2", IsComplete = false },
                new ToDoItem { Id = 3, Name = "name3", IsComplete = true }
            }.Where(item => item.Id.ToString() == _getOptions.SelectCriteria).ToList();      
        } 
    }
}
