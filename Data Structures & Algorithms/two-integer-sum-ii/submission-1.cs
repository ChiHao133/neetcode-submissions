public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1 - i;
        while(i<j){
            int left= numbers[i];
            int right = numbers[j];
            if(left + right == target) return new int[]{i + 1, j + 1};
            else if(left + right > target) j--;
            else if(left + right < target) i++;
        }
        return new int[0];
    }   
}
