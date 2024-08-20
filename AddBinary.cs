public class Solution {
    public string AddBinary(string a, string b) {
        int ptr1 = a.Length - 1;
        int ptr2 = b.Length - 1;
        int carry = 0;
        List<int> sum = new List<int>();

        while (ptr1 >= 0 || ptr2 >= 0 || carry == 1) {
            if (ptr1 >= 0) {
                carry += a[ptr1--] - '0';
            }
            if (ptr2 >= 0) {
                carry += b[ptr2--] - '0';
            }

            sum.Add(carry % 2);
            carry /= 2;
        }

        sum.Reverse();
        return String.Concat(sum);
    }
}
