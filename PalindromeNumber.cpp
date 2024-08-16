class Solution {
public:
    bool isPalindrome(int x) {
        if (isNegative(x)) {
            return false;
        }
        int og_x = x;
        long ans = 0;
        while (x > 0) {
            ans = (ans * 10) + (x % 10);
            std::cout << "\nx:" << x << ", x%10:" << x % 10 << " ans:" << ans;
            x = x / 10;
        }

        if (ans == og_x) {
            return true;
        }
        return false;
    }

    bool isNegative(int x) {
        if (x < 0) {
            return true;
        }
        else {
            return false;
        }
    }
 };
