public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> map = new Dictionary<int,int>();
       int [] indices = new int[2];
       for(int i=0;i<=nums.Length-1;i++)
       {
          int result = target-nums[i];
          if(map.ContainsKey(result))
          {
               indices[0] = map[result];
               indices[1] = i;
               return indices;
          }
          else
          {
               map.Add(nums[i],i);
          }
          
       }
       return indices;
    }
}
