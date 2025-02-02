using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    class SingleFamily : Housing
    {
        private decimal rentPerUnit;
        private int sqFootage;
        private int numOfBedRooms;
        private int numOfBathrooms;
        private bool hasPorch;
        private bool garageAvailable;

        public SingleFamily(string hAddr, string hType, int yBuilt, int hUnits, decimal rPerUnit, int sFoot, int nBeds, int nBaths, bool hPorch, bool gAvail)
            : base(hAddr, hType, yBuilt, hUnits)
        {
            rentPerUnit = rPerUnit;
            sqFootage = sFoot;
            numOfBedRooms = nBeds;
            numOfBathrooms = nBaths;
            hasPorch = hPorch;
            garageAvailable = gAvail;

        }
        public override decimal ProjectedRentalAmt()
        {
            return rentPerUnit * 12;
        }
    }
}
