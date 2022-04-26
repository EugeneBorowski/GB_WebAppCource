using System.Collections.Generic;

namespace GB_WebAppCource.DAL.Entities
{
    public class Client : Entity
    {
        public string name { get; set; }
        public List<Contract> contracts { get; set; }
    }
}
