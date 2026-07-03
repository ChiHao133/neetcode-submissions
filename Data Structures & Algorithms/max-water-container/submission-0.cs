public class Solution {
    public int MaxArea(int[] heights) {
        int max=0;
        int i= 0;
        int j = heights.Length-1;
        int minH=0;
        while(i<j){
            minH= heights[i]<heights[j] ? heights[i]:heights[j];
            if((minH*(j-i))>=max) max=minH*(j-i);
            if(heights[i]<heights[j])i++;
            else j--;
        }
        return max;
    }
}
