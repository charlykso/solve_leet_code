class Solution {
    public void moveZeroes(int[] nums) {
        int i, j = 0, k;
        int end = nums.length - 1;
        int count = 0;
        
        for(i = 0; i <= end; i++)
        {
            if(nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;
                count++;
            }
        }
        for(k = count; k <= end; k++)
        {
            nums[k] = 0;
        }
    }
}