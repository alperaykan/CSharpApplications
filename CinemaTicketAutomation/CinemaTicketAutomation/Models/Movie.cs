using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Models
{
    public class Movie : BaseClass
    {
        public string picturePath { get; set; }
        public int minute { get; set; }
        public int price { get; set; }
        //public enum category { get; set; }
        public List<Session> sessions { get; set; }

    }
}
