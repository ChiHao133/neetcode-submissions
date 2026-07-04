public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(c=='(' || c=='{' || c=='[') stack.Push(c);
            else {
                if(stack.Count()==0) return false;
                char close = stack.Pop();
                if(c==')' && close != '(' ||
                    c=='}' && close != '{' ||
                    c==']' && close != '[' ) return false;
            }
        }
        return stack.Count()==0;
    }

}
