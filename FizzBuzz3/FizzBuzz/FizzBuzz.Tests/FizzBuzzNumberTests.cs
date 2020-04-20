using FizzBuzz.Generator;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzNumberTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "lucky")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(15, "fizzbuzz")]
        [TestCase(19, "19")]
        public void Given_An_Integer_Correct_FizzBuzz_Returned(int number, string output)
        {
            var fizzBuzzNumber = new FizzBuzzNumber(number);
            
            Assert.AreEqual(output, fizzBuzzNumber.ToString());
        }
    }
}