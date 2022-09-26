using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //---Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //---Act
            string actual = customer.FullName;

            //---Assert
            Assert.AreEqual (expected, actual);



        }
        //[TestMethod]
        //public void StaticTest()
        //{
        //    //---Arrange
        //    var c1 = new Customer();
        //    c1.FirstName = "Bilbo";
        //    string expected = "Baggins, Bilbo";

        //    //---Act
        //    string actual = customer.FullName;

        //    //---Assert
        //    Assert.AreEqual(expected, actual);



        //}
    }
}
