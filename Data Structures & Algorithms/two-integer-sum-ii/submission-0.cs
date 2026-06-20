public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int min = 0;
        int max = numbers.Length-1;
        int [] indices = new int[2];
        while(min<max)
        {
            if(target>(numbers[min]+numbers[max]))
            {
                min++;
            }
            else if(target<(numbers[max]+numbers[min]))
            {
                max--;
            }
            else if(target == (numbers[max]+numbers[min]))
            {
                indices[0] = min + 1;
                indices[1] = max + 1;
                break;
            }
        }
        return indices;
    }
}
