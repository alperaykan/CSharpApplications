using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : User
    {
        public string classRoom { get; set; }
        public int okulNo { get; set; }


        public void DoHomework()
        {
            System.Windows.Forms.MessageBox.Show("ödev yapılıyor..");
        }
    }
}
