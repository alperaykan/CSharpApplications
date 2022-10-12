using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : User
    {
      
        public Student(int _okulNo, string _userName, string _password) : base(_userName, _password)
        {
            okulNo = _okulNo;
        }

        public Classroom classroom { get; set; }
        public int okulNo { get; set; }
        public Teacher[] teachers { get; set; }
        public Ders[] dersler { get; set; }

        public void DoHomework()
        {
            System.Windows.Forms.MessageBox.Show("ödev yapılıyor..");
        }
    }
}
