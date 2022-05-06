using System.Collections.Generic;
using GB_WebAppCource.DAL.Entities;

namespace GB_WebAppCource.Controllers.Models
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<ContractDto> contracts { get; set; }
    }
}
