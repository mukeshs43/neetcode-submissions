public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int [] ans = new int[(nums.Length-1)*2];
        ans = [..nums,..nums];
        return ans;
    }
}