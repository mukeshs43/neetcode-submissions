public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> stringLists = new Dictionary<string,List<string>>();
       
       for(int i=0;i<=strs.Length-1;i++)
       {
          char [] chars = strs[i].ToCharArray();
          Array.Sort(chars);
          string Newword =  new string (chars);
           if(stringLists.ContainsKey(Newword))
           {
              stringLists[Newword].Add(strs[i]);
           }
           else
           { 
             char [] str = strs[i].ToCharArray();
             Array.Sort(str);
             string word = Convert.ToString(new string(str));
             stringLists.Add(word,new List<string> {strs[i]});
           }
       }
        List<List<string>> newstring = new List<List<String>>();
        foreach(var i in stringLists)
        {newstring.Add(i.Value);
         Console.WriteLine(i);
        }
        return stringLists.Values.ToList();
    }
}
