public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool b = false;
        List<int> numbers = new List<int>();
        for(int i=0;i<=nums.Length-1;i++)
        {
            if(numbers.Contains(nums[i]))
            {
                return true;
            }
            numbers.Add(nums[i]);
        }
        return b;
    }
}