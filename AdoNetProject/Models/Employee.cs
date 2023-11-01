using AdoNetProject.Enums;
using AdoNetProject.Interfaces;

namespace AdoNetProject.Models
{
    public class Employee : IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
