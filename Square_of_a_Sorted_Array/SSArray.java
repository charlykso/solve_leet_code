class Solution {
    public int[] sortedSquares(int[] nums) {
        int i; 
        int j;
        int index = nums.length - 1;
        int start = 0;
        int end = nums.length - 1;
        int[] myArr = new int[index + 1];
        while(start <= end)
        {
            i = nums[start] * nums[start];
            j = nums[end] * nums[end];
            if(i > j)
            {
                myArr[index--] = i;
                start++;
            }
            else
            {
                myArr[index--] = j;
                end--;
            }
        }
        
        return myArr;
    }
}