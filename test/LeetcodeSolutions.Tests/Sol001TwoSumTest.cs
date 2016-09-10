using Xunit;

namespace SumitGouthaman.LeetcodeSolutions.UnitTests
{
    public class Sol001TwoSumTest
    {
        private readonly Sol001TwoSum _solution;
        public Sol001TwoSumTest()
        {
            _solution = new Sol001TwoSum();
        }

        [Theory]
        [InlineData(new int[] { }, 10)]
        [InlineData(new int[] { 1 }, 10)]
        public void TwoSum_InputArraySizeLessThan2_EmptyOutput(int[] input, int target)
        {
            int[] result = _solution.TwoSum(input, target);
            Assert.Equal(0, result.Length);
        }

        [Theory]
        [InlineData(new int[] { 2, 3 }, 10)]
        [InlineData(new int[] { 5, 6 }, 10)]
        [InlineData(new int[] { 1, 5, 6 }, 10)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 10)]
        public void TwoSum_InputArrayHasTwoOrMoreElementsNoSolution_EmptyOutput(int[] input, int target)
        {
            int[] result = _solution.TwoSum(input, target);
            Assert.Equal(0, result.Length);
        }

        [Theory]
        [InlineData(new int[] { 2, 8 }, 10, new int[] { 0, 1 })]
        [InlineData(new int[] { 5, 5 }, 10, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 4, 6, 5 }, 10, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 4, 4, 6, 5 }, 10, new int[] { 1, 3 })]
        [InlineData(new int[] { 1, 2, 4, 5, 7, 8 }, 10, new int[] { 1, 5 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })] // Example from Leetcode
        public void TwoSum_InputArrayHasTwoOrMoreElementsHasSolution_CorrectOutput(int[] input, int target, int[] expectedResult)
        {
            int[] result = _solution.TwoSum(input, target);
            Assert.Equal(expectedResult, result);
        }
    }
}
