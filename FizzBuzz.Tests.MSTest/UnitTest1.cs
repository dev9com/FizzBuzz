using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.AreEqual(FizzBuzz.GetOutput(3), "Fizz");
            Assert.AreEqual(FizzBuzz.GetOutput(6), "Fizz");
            Assert.AreEqual(FizzBuzz.GetOutput(9), "Fizz");
        }

        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.AreEqual(FizzBuzz.GetOutput(5), "Buzz");
            Assert.AreEqual(FizzBuzz.GetOutput(10), "Buzz");
            Assert.AreEqual(FizzBuzz.GetOutput(20), "Buzz");
        }

        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.AreEqual(FizzBuzz.GetOutput(15), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.GetOutput(30), "FizzBuzz");
            Assert.AreEqual(FizzBuzz.GetOutput(45), "FizzBuzz");
        }

        [TestMethod]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.AreEqual(FizzBuzz.GetOutput(7), "7");
            Assert.AreEqual(FizzBuzz.GetOutput(17), "17");
            Assert.AreEqual(FizzBuzz.GetOutput(1), "1");
        }
    }
}
