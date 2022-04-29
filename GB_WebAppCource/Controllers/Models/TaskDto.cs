using System;

namespace GB_WebAppCource.Controllers.Models
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string taskName { get; set; }
        public double price { get; set; }
        public bool isDone { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
