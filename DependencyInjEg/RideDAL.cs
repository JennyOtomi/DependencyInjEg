using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjEg
{
    public interface IRideDAL
    {
        List<Ride> SelectAllRides();
    }
    public class RideDAL : IRideDAL
    {
        public List<Ride> SelectAllRides()
        {
            List<Ride> ListRides = new List<Ride>();

            ListRides.Add(new Ride() { ID = 1, Departure = "Agege", Destination = "Victoria Island", Number_Of_Seats = 2, Pricing_Option = "Cash", User_name = "omolola.king" });
            ListRides.Add(new Ride() { ID = 2, Departure = "Ikorodu", Destination = "Ikeja", Number_Of_Seats = 1, Pricing_Option = "Free", User_name = "AnjiCoker" });
            ListRides.Add(new Ride() { ID = 3, Departure = "Berger", Destination = "Badagry", Number_Of_Seats = 2, Pricing_Option = "Cash", User_name = "olusegunbalogun" });
            ListRides.Add(new Ride() { ID = 4, Departure = "Ikoyi", Destination = "Ipaja", Number_Of_Seats = 2, Pricing_Option = "Cash", User_name = "maryam.bale" });

            return ListRides;

        }
    }
}
