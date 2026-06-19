public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> repeatenos = new Dictionary<int,int>();
       List<int> nos = new List<int>();
        for(int i=0;i<nums.Length;i++)
        {
           if(repeatenos.ContainsKey(nums[i]))
           {
              repeatenos[nums[i]]++;
           }
           else
           {
               repeatenos.Add(nums[i],1);
           }

        }
        foreach(var i in repeatenos.OrderByDescending(x => x.Value).Take(k))
        {
               nos.Add(i.Key);

        }

        return nos.ToArray();
    }
}
