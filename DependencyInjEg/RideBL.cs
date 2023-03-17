using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjEg
{
    public class RideBL
    {
        public IRideDAL rideDAL;

        public RideBL(IRideDAL rideDAL)
        {
            this.rideDAL = rideDAL;
        }

        public List<Ride> GetAllRides()
        {
            return rideDAL.SelectAllRides();
        }
    }
}
