using System.ComponentModel.DataAnnotations;

namespace CarsShop.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public IsAdmin IsAdmin { get; set; }
    }
    public enum IsAdmin
    {
        Admin = 0,
        User = 1
    }
}
