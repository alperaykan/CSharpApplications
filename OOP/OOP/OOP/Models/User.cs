using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Models
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        public string eMail { get; set; }

        public void Login (string loginDate)
        {
           MessageBox.Show($"{loginDate} tarihinde {userName} adlı kullanıcı giriş yapmıştır.");
        }
    }
}