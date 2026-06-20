public class Solution {
    public int Search(int[] nums, int target) {
        int min =0;
        int max = nums.Length-1;
       int index =-1;
        while(min<=max)
        {
            int median = min +(max-min)/2;

            if(nums[median]==target)
            {
               return median;
            }
            else if(nums[median]>target)
            {
                max--;
            }
            else if(nums[median]<target)
            {
                 min++;
            }
            
        }
        return index;
    }
}
