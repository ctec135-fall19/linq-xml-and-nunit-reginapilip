using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyMathConsoleApp;

namespace MyMath2.UnitTests
{
    [TestFixture]
    public class MyMath2Tests
    {
        // this tests the second set of method calls in Main
        // the ones with the try catch block
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.That(MyMathConsoleApp.MyMath2.Add(55, 65), Is.EqualTo(120));
        }
        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => MyMathConsoleApp.MyMath2.Add(156, 200), Throws.Exception);
        }
    }
}
