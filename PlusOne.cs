public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] != 9) {
                digits[i] += 1;
                return digits;
            }
            else {
                digits[i] = 0;
            }
        }

        if (digits[0] == 0) {
            digits = new int[digits.Length + 1];
            digits[0] = 1;
        }

        return digits;
    }
}
