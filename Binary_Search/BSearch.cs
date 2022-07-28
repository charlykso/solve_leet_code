public class Solution {
    public int Search(int[] nums, int target) {
        int start, end, middle = 0;
        start = 0;
        end = (nums.Length) - 1;
        while(start <= end)
        {
            middle = (start + end) / 2;
            if(nums[middle] == target)
            {
                return (middle);
            }
            else if(nums[middle] > target)
            {
                end = (middle - 1);
            }
            else if(nums[middle] < target)
            {
                start = (middle + 1);
            }
        }
        return (-1);
    } 
}