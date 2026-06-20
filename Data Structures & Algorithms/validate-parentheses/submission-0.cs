public class Solution {
    public bool IsValid(string s) {
        Stack<char> characters = new Stack<char>();

        foreach(char c in s)
        {
            if(c=='(' || c=='{' || c=='[')
            {
                characters.Push(c);
            }
            else 
            {
                if(characters.Count==0)
                   return false;

                char ret = characters.Pop();

                if(ret =='(' && c!=')' ||
                   ret =='{' && c!='}' ||
                   ret =='[' && c!=']')
                   {
                    return false;
                   }
            }
        }
        return characters.Count==0;
  
    }
}
