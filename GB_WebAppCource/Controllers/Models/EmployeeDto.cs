using System.Collections.Generic;
using GB_WebAppCource.DAL.Entities;

namespace GB_WebAppCource.Controllers.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<TaskDto> tasks { get; set; }
    }
}
