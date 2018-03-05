using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIFramework.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void getAddressTest()
        {
            Student S1 = new Student();

        
            Assert.AreEqual("Elisagårdsvej 5", S1.getAddress());
        }
    }
}