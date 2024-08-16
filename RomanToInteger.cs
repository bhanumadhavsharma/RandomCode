public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string,int> dict = new Dictionary<string, int>();
        dict.Add("I",1);
        dict.Add("V",5);
        dict.Add("X",10);
        dict.Add("L",50);
        dict.Add("C",100);
        dict.Add("D",500);
        dict.Add("M",1000);
        dict.Add("IV",4);
        dict.Add("IX",9);
        dict.Add("XL",40);
        dict.Add("XC",90);
        dict.Add("CD",400);
        dict.Add("CM",900);

        int total = 0;
        for (int i = s.Length - 1; i > -1; i--) {
            string letter = s[i].ToString();
            if (i - 1 > -1) {
                if (dict[s[i-1].ToString()] < dict[letter]) {
                    letter = s[i-1].ToString() + letter; 
                    i--;
                }
            }

            total += dict[letter];
        }

        return total;
    }
}
