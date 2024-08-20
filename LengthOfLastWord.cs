public class Solution {
    public int LengthOfLastWord(string s) {
        string[] sWords = s.Split(" ");
        for(int i = sWords.Length -1; i >= 0; i--) {
            if (!string.IsNullOrWhiteSpace(sWords[i])){
                return sWords[i].Length; 
            }
        }
        return 0;
    }
}

