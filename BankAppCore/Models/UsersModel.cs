using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication.Model
{
    public class UserModel
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }

        public UserModel(string fullName, string email, string password, string phone, string address)
        {
            this.FullName = fullName;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phone;
            this.HomeAddress = address;


        }
        public UserModel()
        {

        }
    }

}
