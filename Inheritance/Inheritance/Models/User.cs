﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class User
    {
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
