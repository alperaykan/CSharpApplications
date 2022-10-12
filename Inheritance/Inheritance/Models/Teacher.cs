using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    class Teacher : User
    {
        public string[] classRooms { get; set; }
        public string branch { get; set; }

        public void GiveHomework()
        {
            System.Windows.Forms.MessageBox.Show("ödev veriliyor...");
        }
    }
}
