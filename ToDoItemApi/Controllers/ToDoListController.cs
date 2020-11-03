using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoItemApi.Models;

namespace ToDoItemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private IConfiguration _configuration;

        public ToDoListController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult<List<ToDoItem>> Get()
        {
            var selectCriteria = _configuration.GetValue<string>("GetOptions:SelectCriteria");
            Console.WriteLine(selectCriteria);

            return Ok(new List<ToDoItem>
                {
                    new ToDoItem {Id = 1, Name = "name1", IsComplete = true},
                    new ToDoItem {Id = 2, Name = "name2", IsComplete = false},
                    new ToDoItem {Id = 3, Name = "name3", IsComplete = true}
                }.Where(item => item.Id.ToString() == selectCriteria));
        }
    }
}