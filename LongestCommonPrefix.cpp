class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        sort(strs.begin(), strs.end());
        int strLen = 0;
        int finalWord = strs.size() - 1;
        for (int i = 0; i < strs[0].length(); i++) {
            if (strs[0][i] != strs[finalWord][i]) {
                break;
            }
            strLen++;
        }
        return strs[0].substr(0,strLen);
    }
};
