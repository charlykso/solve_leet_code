class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int i = 0;
        int j = 1;
        int x, y;
        int end = numbers.length - 1;
        int[] twoIndex = new int[2];
        
        while(i <= end)
        {
            if(numbers[i] + numbers[j] == target)
            {
                x = i + 1;
                y = j + 1;
                twoIndex[0] = x;
                twoIndex[1] = y;
                i++;
                j++;
                return twoIndex;
            }
            else if(j == end)
            {
                i++;
                j = i + 1;
            }
            else{
                j++;
            }
        }
        return twoIndex;
    }
}