// Link: https://leetcode.com/problems/two-sum/

using System.Collections.Generic;

namespace SumitGouthaman.LeetcodeSolutions
{
    public class Sol001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
                return new int[] { };

            // Map from number => position
            IDictionary<int, int> seenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                int position;
                if (seenNumbers.TryGetValue(diff, out position))
                {
                    return new int[] { position, i };
                }

                if (!seenNumbers.ContainsKey(nums[i]))
                    seenNumbers.Add(nums[i], i);
            }

            return new int[] { }; // No solution possible
        }
    }
}
