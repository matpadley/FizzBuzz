using System.Linq;
using FizzBuzz.Generator;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private Generator.FizzBuzz _fizzBuzz;
        
        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new Generator.FizzBuzz(Enumerable.Range(1, 20));
        }
        
        [Test]
        public void Given_A_Fixed_Twenty_Int_Range_Expected_FizzBuzz_Output()
        {
            var expectedOutput = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz";
            
            Assert.AreEqual(expectedOutput, _fizzBuzz.Output);
        }
    }
}