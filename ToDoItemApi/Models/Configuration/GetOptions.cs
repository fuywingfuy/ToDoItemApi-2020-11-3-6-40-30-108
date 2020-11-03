using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoItemApi.Models.Configuration
{
    public sealed class GetOptions
    {
        [Required]
        public string SelectCriteria { get; set; }
    }
}
