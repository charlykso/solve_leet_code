class Solution(object):
    def search(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        start = 0
        end = len(nums) - 1
        mid = 0
        while(start <= end):
            mid = (start + end) / 2
            guess = nums[mid]
            if guess == target :
                return mid
            if guess < target :
                start = mid + 1
            else :
                end = mid - 1
        
        return (-1)