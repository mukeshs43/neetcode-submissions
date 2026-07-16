public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      int n = nums.Length;
      int [] res = new int[n];

      res[0]=1;
      for(int i=1;i<n;i++)
      {
        res[i] = nums[i-1] * res[i-1];
      }

      int suffixproduct =1;
      for(int j=n-1;j>=0;j--)
      {
          res[j] *= suffixproduct;
          suffixproduct*=nums[j];
      }
      return res;
    }
}
