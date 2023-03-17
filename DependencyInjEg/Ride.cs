using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjEg
{
    public class Ride
    {
        public int ID { get; set; }
        public string User_name { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

        public int Number_Of_Seats { get; set; }
        public string Pricing_Option { get; set; }
    }
}
