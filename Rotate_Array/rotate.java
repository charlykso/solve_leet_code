class Solution {
    public void rev(int[] myArr, int i, int j)
    {
        int temp;
        while(i <= j)
        {
            temp = myArr[i];
            myArr[i] = myArr[j];
            myArr[j] = temp;
            i++;
            j--;
        }
    }
    
    public void rotate(int[] nums, int k) {
        k = k % nums.length;
        rev(nums, 0, (nums.length - 1));
        rev(nums, 0, k - 1);
        rev(nums, k, (nums.length - 1));
    }
    

}