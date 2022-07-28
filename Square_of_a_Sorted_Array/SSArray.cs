public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i, x;
        for(i = 0; i < nums.Length; i++)
        {
            x = nums[i] * nums[i];
            nums[i] = x;
        }
        Array.Sort(nums);
        return nums;
    }
}