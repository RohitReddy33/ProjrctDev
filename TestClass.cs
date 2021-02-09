using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectDev
{
    [TestFixture]
    [Category("UnitTests")]
    class TestClass
    {
        [Test]
        public void Test()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Test", class1.Test());
        }
    }
}
