public class Solution {
    public int Search(int[] nums, int target) {
        
        int peak = FindPeak(nums);
        int sol = BinarySearch_ASC(target, nums, 0, peak);
        
        if (sol != -1)
        {
            return sol;
        }
        else if (peak != nums.Length - 1)
        {
            sol = BinarySearch_ASC(target, nums, peak + 1, nums.Length - 1);
            if (sol != -1)
            {
                return sol;
            }
            else
            {
                return -1;
            }
        }
        else 
        {
            return -1;
        }
    }
    
    int FindPeak(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        
        /*if (nums.Length == 2)
        {
            if (nums[0] > nums[1])
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        while (start <= end && start >= 0 && (end <= nums.Length - 1))
        {
            int mid = start + ((end - start) / 2);
            
            if (start == end)
            {
                return mid; 
            }
            else if (nums[mid] < nums[mid - 1])
            {
                end = mid - 1;
            }
            else if (nums[mid] > nums[mid - 1])
            {
                start = mid;
            }
        }
        
        return start; */
        
        while (start <= end && start >= 0 && (end <= nums.Length - 1))
        {
            int mid = start + ((end - start) / 2);
            
            if (mid < end && (nums[mid] > nums[mid + 1]))
            {
                return mid;
            }
            if (mid > start && (nums[mid] < nums[mid - 1]))
            {
                return mid - 1;
            }
            
            if (nums[mid] <= nums[start])
            {
                end = mid - 1;    
            }
            else if (nums[mid] > nums[start])
            {
                start = mid + 1;
            }
        }
        
        return -1;
    }
    
    int BinarySearch_ASC(int target, int[] nums, int start, int end)
    {
        while (start <= end && start >= 0 && (end <= nums.Length - 1))
        {
            int mid = start + ((end - start) / 2);
            
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
        }
        
        return -1;
    }
}
