using System;
using Xunit;

namespace SumitGouthaman.LeetcodeSolutions.UnitTests
{
    public class Solution1UnitTest
    {
        private readonly Solution1 _solution1;
        public Solution1UnitTest()
        {
            _solution1 = new Solution1();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _solution1.IsPrime(1);
            Assert.False(result, $"1 should not be prime");
        }
    }
}
