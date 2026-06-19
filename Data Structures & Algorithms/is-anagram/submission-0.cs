public class Solution {
    public bool IsAnagram(string s, string t) {

      if(s.Length!=t.Length) return false;

        char [] ch = s.ToCharArray();
        char [] th = t.ToCharArray();

        Array.Sort(ch);
        Array.Sort(th);

       return new string(ch) == new string(th);
    }
}
