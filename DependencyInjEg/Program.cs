using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RideBL rideBL = new RideBL(new RideDAL());
            List<Ride> ListRide = rideBL.GetAllRides();
            foreach(Ride rd in ListRide)
            {
                Console.WriteLine("ID ={0}, User_name ={1}, Departure={2}, Destination={3}, Number_Of_Seats={4}, Pricing_Option={5}", rd.ID, rd.User_name, rd.Departure, rd.Destination, rd.Number_Of_Seats, rd.Pricing_Option);
            }
            Console.ReadKey();
        }
    }
}
