using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class User
    {

        public User(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
        }

        public string userName { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string phoneNumber { get; set; }

        public string GetFullName()
        {
            return $"{name} {surName}";
        }
    }
}
