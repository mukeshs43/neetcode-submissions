public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
    
      List<int> nos = new List<int>();
       
       for(int i=0;i<nums.Length;i++)
       {
          int result =1;
          for(int j=0;j<nums.Length;j++)
          {
               if(i!=j)
               {
                 result*=nums[j];
               }
          }
          nos.Add(result);
       }

       return nos.ToArray();

    }
}
