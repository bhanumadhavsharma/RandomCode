public class Solution {
    public bool IsValid(string s) {
        Stack par = new Stack();
        char[] parArr = s.ToCharArray();

        for(int i = 0; i < parArr.Length; i++) {
            if (parArr[i] == '(' || parArr[i] == '{' || parArr[i] == '[') {
                par.Push(parArr[i]);
            }
            else if (par.Count() == 0) {
                return false;
            }
            else if (parArr[i] == ')' && par.Peek().toString().charAt(0) == '(') {
                par.Pop();
            }
            else if (parArr[i] == '}' && par.Peek().toString().charAt(0) == '{') {
                par.Pop();
            }
            else if (parArr[i] == ']' && par.Peek().toString().charAt(0) == '[') {
                par.Pop();
            }
            else {
                return false;
            }
        }

        return true;
    }
}
