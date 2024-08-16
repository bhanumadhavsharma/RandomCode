class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        
        /**int i = 1;
        while (i < nums.size())
        {
            if (nums[i] != nums[i-1])
            {
                ++i;
            }
            else
            {
                nums.erase(nums.begin() + i);
            }
        }
        
        return nums.size();**/
        
        int answer = 0;
        
        for (int i = 1; i < nums.size(); ++i)
        {
            if(nums[i] == nums[i-1])
            {
                nums.erase(nums.begin() + i);
                --i;
            }
        }
        
        answer = nums.size();
        return answer;
    }
};
