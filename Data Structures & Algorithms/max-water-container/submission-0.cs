public class Solution {
    public int MaxArea(int[] heights) {
        int left=0;
        int right = heights.Length-1;
        int maxwater=0;

        while(left<right)
        {
            int water = Math.Min(heights[left],heights[right])*(right-left);
            maxwater = Math.Max(maxwater,water);

            if(heights[left] < heights[right])
            {
              left++;
            }
            else
            {
              right--;
            }
        }
        return maxwater;
    }
}
