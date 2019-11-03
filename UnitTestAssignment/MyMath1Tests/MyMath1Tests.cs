using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// adding necessary components
using NUnit.Framework;
using MyMathConsoleApp;

namespace MyMath1.UnitTests
{
    [TestFixture]
    public class MyMath1Tests
    {
        // tests first method call
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.AreEqual(120, MyMathConsoleApp.MyMath1.Add(55,65));
        }
        // tests second method call
        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorrectSum()
        {
            Assert.AreEqual(356, MyMathConsoleApp.MyMath1.Add(156, 200));
        }
    }
}
