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
    public class Class1Tests
    {
        [TestMethod()]
        public void getNameTest()
        {
            Class1 C1 = new Class1();

            Assert.AreEqual("Daniel",C1.getName());
        }
    }
}