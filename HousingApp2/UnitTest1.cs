using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HousingApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SingleFamily singleFamily1 = new SingleFamily("123 Warf Ave", "SingleFamily",
                1984, 1, 2600.00M, 1500, 2, 3, false, false);

            SingleFamily singleFamily2 = new SingleFamily("77 Bixby Ct", "SingleFamily",
                1954, 1, 2200.00M, 1500, 5, 2, true, false);

            SingleFamily singleFamily3 = new SingleFamily("8810 French Ct", "SingleFamily",
                1911, 1, 1600.00M, 2500, 7, 4, true, true);

            SingleFamily singleFamily4 = new SingleFamily("11 Broadway Ave", "SingleFamily",
                1999, 1, 4600.00M, 1500, 2, 3, false, false);

            SingleFamily singleFamily5 = new SingleFamily("904 CyberHell St", "SingleFamily",
                2084, 1, 7200.00M, 200, 2, 1, false, false);
                        
            public override string ToString()
        {

        }
        }
    }
}
