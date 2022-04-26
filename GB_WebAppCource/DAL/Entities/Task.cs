using System;

namespace GB_WebAppCource.DAL.Entities
{
    public class Task : Entity
    {
        public string taskName { get; set; }
        public double price { get; set; }
        public bool isDone { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}