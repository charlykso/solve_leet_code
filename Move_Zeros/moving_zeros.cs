class Solution {
    public void moveZeroes(int[] nums) {
	int start = 0;
	int end = nums.Length - 1;
	int x = 0, i = 0;
	int k = end;
	int[] newArr = new int[end + 1];
	if(start < end)
	{
		while(start <= end)
		{
			if(nums[start] == 0)
			{
				newArr[k] = 0;
				k--;
				start++;
			}
			else
			{
				newArr[x] = nums[start];
				start++;
				x++;
			}
		}
		while(i <= end)
		{
			nums[i] = newArr[i];
			i++;
		}
	}
    }
}