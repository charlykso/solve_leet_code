public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int start = 0;
        int end = (nums.Length) - 1;
        int mid;
        
        while(start <= end)
        {
            mid = (start + end) / 2;
            
            if(nums[mid] == target)
            {
                return (mid);
            }
            else if(nums[mid] > target)
            {
                end = mid - 1;
            }
            else if(nums[mid] < target)
            {
                start = mid + 1;
            }
        }
        return start;
    }
}