public class Solution {
    public bool IsPalindrome(string s) {
        int min = 0;
        int max = s.Length-1; 

        while(min<max)
        {
            while(min<max && !char.IsLetterOrDigit(s[min]))
                min++;

            while(min<max && !char.IsLetterOrDigit(s[max]))
                max--;

            if(char.ToLower(s[min])!=char.ToLower(s[max]))
            {  
                
                return false;
            }
            
            min++;
            max--;
        }
        return true;

    }
}
