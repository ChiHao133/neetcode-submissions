public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = i + 1;
        while(i<j){
            if(numbers[i] != numbers[j]){
                if (numbers[i] + numbers[j] == target) return new int[]{i+1,j+1};
                j++;
                if(j == numbers.Length){ i++; j = i + 1;}
            }
            else{
                j++;
            }
        }

        return new int[0];

    }
}
