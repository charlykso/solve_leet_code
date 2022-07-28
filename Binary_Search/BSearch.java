class Solution {
    public int search(int[] nums, int target) {
        int start = 0;
        int end = (nums.length) - 1;
        int mid = 0;
        while(start <= end)
        {
            mid = (start + end) / 2;
            int guess = nums[mid];
            if(guess == target)
            {
                return mid;
            }
            if(guess < target)
            {
                start = mid + 1;
            }
            else{
                end = mid - 1;
            }
        }
        return -1;
    }
}