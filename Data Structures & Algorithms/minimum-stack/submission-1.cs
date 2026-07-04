public class MinStack {
    private Stack<int> stack;
    private Stack<int> min;
    public MinStack() {
        stack= new Stack<int>();
        min = new Stack<int>();
        min.Push(int.MaxValue);
    }
    
    public void Push(int val) {
        stack.Push(val);
        int minx = min.Peek() < val? min.Peek() : val;
        min.Push(minx);
    }
    
    public void Pop() {
        stack.Pop();
        min.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
