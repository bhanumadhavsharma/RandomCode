class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int start = 0;
        int end = nums.size() - 1;
        cout << "target: " << target << endl;
        while (start <= end)
        {
            int mid = start + ((end - start) / 2);
            cout << "start/end: " << start << "/" << end << ", mid: " << mid << endl; 
            if (target < nums.at(mid))
            {
                end = mid - 1;
            }
            else if (target > nums.at(mid))
            {
                start = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return start;
    }
};
