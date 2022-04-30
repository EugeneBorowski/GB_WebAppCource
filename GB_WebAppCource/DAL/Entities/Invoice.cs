using System.Collections.Generic;

namespace GB_WebAppCource.DAL.Entities
{
    public class Invoice : Entity
    {
        public List<Task> taskList { get; set; }

        public int totalPrice;
    }
}