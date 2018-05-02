using Packt.PrimeFactors;
using System;
using Xunit;

namespace PrimeFactorsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestInt4()
        {
            // arrange
            int start = 4;
            string expected = "2, 2";
            var pf = new PrimeFactors();
            // act
            string actual = pf.Fetch(start);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestInt7()
        {
            // arrange
            int start = 7;
            string expected = "7";
            var pf = new PrimeFactors();
            // act
            string actual = pf.Fetch(start);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestInt30()
        {
            // arrange
            int start = 30;
            string expected = "2, 3, 5";
            var pf = new PrimeFactors();
            // act
            string actual = pf.Fetch(start);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestInt40()
        {
            // arrange
            int start = 40;
            string expected = "2, 2, 2, 5";
            var pf = new PrimeFactors();
            // act
            string actual = pf.Fetch(start);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestInt50()
        {
            // arrange
            int start = 50;
            string expected = "2, 5, 5";
            var pf = new PrimeFactors();
            // act
            string actual = pf.Fetch(start);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
