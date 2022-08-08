public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = 1;
        int x, y;
        start = 0;
        int end = numbers.Length - 1;
        int middle = 0;
        int[] twoIndex = new int[2];
        while(start <= end)
        {
            middle = (start + end) / 2;
            if(numbers[middle] > target)
            {
                end = middle - 1;
            }
            else if(numbers[middle] <= target)
            {
                
            }
        }
    }
}