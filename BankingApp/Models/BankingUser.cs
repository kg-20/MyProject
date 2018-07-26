using System;
namespace BankingApp.Models
{
    public class BankingUser
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public BankingUser()
        {
        }

    }
}
