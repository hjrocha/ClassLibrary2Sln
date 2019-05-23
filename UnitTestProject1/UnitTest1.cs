using ClassLibrary2;
using System;
using Xunit;

namespace UnitTestProject1
{

    public class UnitTest1
    {

        private readonly Class1 _primeService;

        public UnitTest1()
        {
            _primeService = new Class1();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void Test01()
        {
            int n = _primeService.AddANumberToSeven(5);
            Assert.Equal(n, 5 + 7);
        }


        [Fact]
        public void Test02()
        {
            string test = _primeService.GenerateString(10);
            Assert.Equal(test.Length, 10);
        }
    }
}
