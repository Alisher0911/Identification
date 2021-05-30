using System;
namespace ProjectRegistration.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public string Apikey { get; set; }
    }
}
