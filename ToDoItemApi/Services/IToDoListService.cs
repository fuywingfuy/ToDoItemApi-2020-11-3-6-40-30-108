using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoItemApi.Models;

namespace ToDoItemApi.Services
{
    public interface IToDoListService
    {
        List<ToDoItem> GetToDoItems();
    }
}
