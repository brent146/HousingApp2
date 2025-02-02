using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    class MultiUnit : Housing, IUnit
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentPerUnit;

        public MultiUnit(string hAddr, string hType, int yBuilt, int hUnits, string compName, int numUnits, int rpUnits)
            : base(hAddr, hType, yBuilt, hUnits)

        {
            complexName = compName;
            numberOfUnits = numUnits;
            rentPerUnit = rpUnits;

        }

        public override decimal ProjectedRentalAmt()
        {
            return (rentPerUnit * numberOfUnits) * 12;
        }

        public int GetUnits()
        {
            return homeUnits;
        }
        public override string ToString()
        {
            return complexName + " " + numberOfUnits + " " + rentPerUnit;
        }
    }


}

