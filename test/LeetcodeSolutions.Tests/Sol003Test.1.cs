using Xunit;

namespace SumitGouthaman.LeetcodeSolutions.UnitTests
{
    public class Sol003Test
    {
        private readonly Sol003 _solution;
        public Sol003Test()
        {
            _solution = new Sol003();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("tmmzuxt", 5)]
        public void LengthOfLongestSubstring_VariousInputs_CorrectResult(string input, int expectedResult)
        {
            int result = _solution.LengthOfLongestSubstring(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
