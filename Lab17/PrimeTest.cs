using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab17
{
    public class PrimeTest
    {
        [Fact]
        public void Prime1()
        {
            int expected = 2;
            int result = Prime.PrimeIndex(1);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Prime2()
        {
            int expected = 3;
            int result = Prime.PrimeIndex(2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Prime3()
        {
            int expected = 5;
            int result = Prime.PrimeIndex(3);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Prime4()
        {
            int expected = 7;
            int result = Prime.PrimeIndex(4);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Prime5()
        {
            int expected = 11;
            int result = Prime.PrimeIndex(5);
            Assert.Equal(expected, result);
        }
    }
}
