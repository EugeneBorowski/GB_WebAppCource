using System.Collections.Generic;

namespace GB_WebAppCource.DAL.Entities
{
    public class Employee : Entity
    {
        public string name { get; set; }
        public List<Task> tasks { get; set; }
    }
}
