public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;
        int[] newArr = new int[2];
        
        while(start <= end)
        {
            if(numbers[start] + numbers[end] == target)
            {
                newArr[0] = start + 1;
                newArr[1] = end + 1;
                return newArr;
            }
            else if(numbers[end] + numbers[start]  > target)
            {
                end--;
            }
            else if(numbers[end] + numbers[start] < target)
            {
                start++;
            }
        }
        return newArr;
    }
}