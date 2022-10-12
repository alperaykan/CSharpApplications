using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Classroom
    {
        public int seviye { get; set; }
        public string sube { get; set; }

        public string SınıfTamAd()
        {
            return $"{seviye}-{sube}";
        }
    }
}
