using System;
using Xunit;
using fizzbuzz.Service;

namespace fizzbuzz.UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void Test_Says_Input_1_Should_Be_1()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(1);
            Assert.Equal("1", actual);
        }

        [Fact]
        public void Test_Says_Input_2_Should_Be_2()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(2);
            Assert.Equal("2", actual);
        }

        [Fact]
        public void Test_Says_Input_3_Should_Be_Fizz()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(3);
            Assert.Equal("Fizz", actual);
        }

        
        [Fact]
        public void Test_Says_Input_5_Should_Be_Buzz()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(5);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Test_Says_Input_6_Should_Be_Fizz()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(6);
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void Test_Says_Input_10_Should_Be_Buzz()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(10);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Test_Says_Input_15_Should_Be_FizzBuzz()
        {
            var fizzbuzz = new FizzBuzz();
            var actual = fizzbuzz.Says(15);
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
