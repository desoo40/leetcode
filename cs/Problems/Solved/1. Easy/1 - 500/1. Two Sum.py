class Solution_1:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        lenght = len(nums)

        for i in range(lenght):
            for j in range(i + 1, lenght):
                if (nums[j] + nums[i] == target):
                    return [i, j]
