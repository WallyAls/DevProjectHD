using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS.librarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.librarian.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        //check the method doesn't return null.
        [TestMethod()]
        public void GetRandomPasswordTest1()
        {

            string x = Class1.GetRandomPassword(9);
            Assert.IsNotNull(x);
        }

        //checks that the value returned is the same length as in the parameters.
        [TestMethod()]
        public void GetRandomPasswordTest2()
        {
            string x = Class1.GetRandomPassword(3);
            Assert.IsTrue(x.Length == 3);
        }

        //checks that the value is empty when the length is 0
        [TestMethod()]
        public void GetRandomPasswordTest3()
        {
            string x = Class1.GetRandomPassword(0);
            Assert.IsTrue(x == string.Empty);
        }

        //checks that the getrandompassword method returns different values
        [TestMethod()]
        public void GetRandomPasswordTest4()
        {
            
            
            string x = Class1.GetRandomPassword(10);
            string y = Class1.GetRandomPassword(7);
            Assert.IsTrue(x != y);
        }

        //checks that the getrandompassword eventually has a value of 1
        [TestMethod()]
        public void GetRandomPasswordTest5()
        {
            Assert.IsTrue(Class1.GetRandomPassword(50).Contains("1"));
        }


    }
}