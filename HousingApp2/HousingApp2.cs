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
            return string.Format("Address: {0}\n" + 
                "Home Type: {1:C\n" +
                "Year Built: {2:C}\n" +
                "Home Units: {3:C}\n" +
                "Rent: {4:C}\n" +
                "Square Footage: {5:C}\n" +
                "Beds: {6:C}\n" +
                "Baths: {7:C}\n" +
                "Has Porch?: {8:C}\n" +
                "Garage Available?: {9:C}", );
        }

        //public int GetUnits()
        //{
        //    return homeUnits;
        //}
    }

}
