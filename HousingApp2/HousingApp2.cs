using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    class Housing
    {
        private string homeAddress;
        private string homeType;
        private int yearBuilt;
        public int homeUnits;

        public Housing(string hAddr, string hType, int yBuilt, int hUnits)
        {
            HomeAddress = hAddr;
            HomeType = hType;
            YearBuilt = yBuilt;
            HomeUnits = hUnits;
        }

        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }
            set
            {
                homeAddress = value;
            }

        }
        public string HomeType
        {
            get
            {
                return homeType;
            }
            set
            {
                homeType = value;
            }

        }
        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }

        public int HomeUnits
        {
            get
            {
                return homeUnits;
            }
            set
            {
                homeUnits = value;
            }
        }

        public virtual decimal ProjectedRentalAmt()
        {
            /*
            decimal rentalAmount = 0;

            return rentalAmount;
            */
            return 0.0M;
        }
        public override string ToString()
        {
            return homeAddress + " " + homeType + " " + YearBuilt;
        }

        //public int GetUnits()
        //{
        //    return homeUnits;
        //}
    }

}
