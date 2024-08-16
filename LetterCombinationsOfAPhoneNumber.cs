public class Solution {
    public List<string> LetterCombinations(string digits) {
        
        List<string> result = new List<string>();
        string[] numbers = digits.Split();
        
        if (digits != null && digits.Length > 0){
            List<string> letterMap = new List<string>(){
                "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" 
            };
            dfs(digits, letterMap, result, new StringBuilder(), 0);
        }
        return result;
    }
    
    public void dfs(string digits, List<string> mapOfLetters, List<string> result, StringBuilder sb, int index){
        // when we reach end of number, valid combo should be reached
        if(index==digits.Length){
            result.Add(sb.ToString());
            return;
        }
        
        //get current digit / what letter it represents
        int digit = (int)Char.GetNumericValue(digits, index);
        string letters = mapOfLetters[digit];
        
        // try adding each letter to the string we've built
        for (int i =0; i < letters.Length; i++){
            char ch = letters[i];
            sb.Append(ch);
            dfs(digits, mapOfLetters, result, sb, index + 1);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}
