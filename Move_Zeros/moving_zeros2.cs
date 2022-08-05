public class Solution {
    public void MoveZeroes(int[] nums) {
        int i;
        int k = 0;
        int end = nums.Length - 1;
        int count = 0;
        
        for(i = 0; i <= end; i++)
        {
           
            if(nums[i] != 0)
            {
                nums[k] = nums[i];
                k++;
                count++;
            }
        }
        for(int j = count; j <= end; j++)
        {
            nums[j] = 0;
            
        }
    }
}