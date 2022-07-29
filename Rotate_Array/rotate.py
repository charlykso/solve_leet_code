class Solution:
    def rev(arr: List[int], start: int, end: int):
        while(start <= end) :
            temp = arr[start]
            arr[start] = arr[end]
            arr[end] = temp
            start = start + 1
            end = end - 1
        
    def rotate(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        k = k % len(nums)
        end = len(nums) - 1
        start = 0
        Solution.rev(nums, start, end)
        Solution.rev(nums, start, k - 1)
        Solution.rev(nums, k, (len(nums) - 1))
	