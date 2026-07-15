public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int longestconsecutive =0;
        Array.Sort(nums);
        for(int i=0;i<n;i++)
        { 
            int nextno = nums[i]+1;
            int currentmax =1;
            for(int j=0;j<n;j++)
            {
                if(nextno==nums[j])
                {
                   currentmax++;
                   nextno = nums[j]+1;
                }
                longestconsecutive = Math.Max(longestconsecutive,currentmax);
            }
        }
        return longestconsecutive;
    }
}
