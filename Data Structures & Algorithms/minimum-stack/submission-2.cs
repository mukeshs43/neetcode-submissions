public class MinStack {

Stack<int> st = new Stack<int>();
        Stack<int> minstack = new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        st.Push(val);
        if(minstack.Count==0 || val<=minstack.Peek())
        {
            minstack.Push(val);
        }
        else
        {
            minstack.Push(minstack.Peek());
        }
    }
    
    public void Pop() {
        if(st.Count==0) return;
        st.Pop();
        minstack.Pop();
    }
    
    public int Top() {
        if(st.Count==0)
        {
            return 0;
        }
        else
        {
           return st.Peek();
        }
    }
    
    public int GetMin() {
        if(minstack.Count==0) return -1;
        return minstack.Peek();
    }
}
