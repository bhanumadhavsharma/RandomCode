public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] < 1 || nums[i] > nums.Length)
            {
                i++;
            }
            else if ((nums[i] != i + 1) && (nums[i] != nums[nums[i] - 1]))
            {
                Swap(nums, i, nums[i] - 1);
            }
            else
            {
                i++;
            }
        }
        
        int j = 0;
        while (j < nums.Length)
        {
            if (nums[j] != j + 1)
            {
                return j + 1;
            }
            j++;
        }
        
        return j + 1;
    }
    
    void Swap(int[] nums, int firstIndex, int secondIndex)
    {
        int temp = nums[firstIndex];
        nums[firstIndex] = nums[secondIndex];
        nums[secondIndex] = temp;
    }
}
