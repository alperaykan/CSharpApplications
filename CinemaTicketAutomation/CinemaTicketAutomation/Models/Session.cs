using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Models
{
    public class Session
    {
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public List<Chair> chairs { get; set; }

    }
}
