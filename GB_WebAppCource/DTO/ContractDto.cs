using GB_WebAppCource.DAL.Entities;

namespace GB_WebAppCource.Controllers.Models
{
    public class ContractDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Invoice invoice { get; set; }
    }
}
