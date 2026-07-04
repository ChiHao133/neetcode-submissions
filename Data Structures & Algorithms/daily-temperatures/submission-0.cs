public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] list = new int[temperatures.Length];
        for(int i =0;i< temperatures.Length; i++){
            while(stack.Count() > 0 && temperatures[i] > temperatures[stack.Peek()]){
                int prevI = stack.Pop();
                list[prevI] = i-prevI;
            }
            stack.Push(i);
        }
        return list;
    }
}
