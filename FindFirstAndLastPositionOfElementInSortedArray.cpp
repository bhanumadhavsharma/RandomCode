class Solution {
public:
    vector<int> searchRange(vector<int>& nums, int target) {
        
        // sorted array asc, binary search
        // return start and endpoint of element
        // if not found, return -1,-1
        
        
        // 2 runs of binary search
        // first one finds floor
        // second one finds ceiling
        // if first fails, then return [-1.-1]
        
        vector<int> ans;
        
        if (nums.size() < 1 || target > nums.at(nums.size() - 1) || target < nums.at(0))
        {
            ans.push_back(-1);
            ans.push_back(-1);
            return ans;
        }
        
        int start = 0;
        int end = nums.size() - 1;
        
        // find floor
        while (start <= end)
        {
            int mid = start + ((end - start) / 2);
            if (target > nums.at(mid))
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        if (nums.at(start) == target)
        {
            ans.push_back(start);
        }
        else
        {
            ans.push_back(-1);
            ans.push_back(-1);
            return ans;
        }
        
        // find ceiling
        start = 0;
        end = nums.size() - 1;
        while (start <= end)
        {
            int mid = start + ((end - start) / 2);
            if (target < nums.at(mid))
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        ans.push_back(end);
        
        return ans;
    }
};
