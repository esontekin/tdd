using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService fizzBuzz;

        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzzService();
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("2", fizzBuzz.Print(2));
        }

        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", fizzBuzz.Print(3));
        }
        
        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", fizzBuzz.Print(5));
            Assert.AreEqual("Buzz", fizzBuzz.Print(10));
        }
        
        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.Print(15));
            Assert.AreEqual("FizzBuzz", fizzBuzz.Print(30));
        }
    }
}