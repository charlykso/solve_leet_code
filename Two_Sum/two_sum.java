class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.length - 1;
        int[] newArr = new int[2];
        int sum = 0;

        while(start <= end)
        {
            sum = numbers[start] + numbers[end];

            if(sum == target)
            {
                newArr[0] = start + 1;
                newArr[1] = end + 1;
                return newArr;
            }
            else if(sum  > target)
            {
                end--;
            }
            else if(sum < target)
            {
                start++;
            }
        }
        return newArr;
    }
}