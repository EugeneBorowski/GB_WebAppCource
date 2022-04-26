namespace GB_WebAppCource.DAL.Entities
{
    public class Contract : Entity
    {
        public string name { get; set; }
        public string description { get; set; }
        public Invoice invoice { get; set; }
    }
}