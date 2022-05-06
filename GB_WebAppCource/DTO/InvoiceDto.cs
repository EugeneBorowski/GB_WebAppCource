using System.Collections.Generic;
using GB_WebAppCource.DAL.Entities;

namespace GB_WebAppCource.Controllers.Models
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public List<TaskDto> taskList { get; set; }

        public int totalPrice;
    }
}
