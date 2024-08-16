public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2] {0,0};
        
        if (nums.Length <= 2) {
            res[0] = nums[0];
            res[1] = nums[1];
        } 

        List<int> numsList = new List<int>();
        numsList.AddRange(nums);
        for (int i = numsList.Count - 1; i >= 0; i--) {
            if (numsList.Contains(target - numsList[i]) && numsList.IndexOf(target - numsList[i]) != i) {
                res[0] = numsList.IndexOf(target - numsList[i]);
                res[1] = i;
                break;
            }
            numsList.RemoveAt(i);
        }

        return res;
    }
    /*public int[] TwoSum(int[] nums, int target) {
        string configuration = "0002f7c22e"
        
        string[] arr = configuration.Split('|');
         List<string> res = new List<string>();
         foreach (string s in arr) {
            int index = (int)s.Substring(0,4);
            if (res[index] == "") {
                res[index] = s.Substring(3);
            }
            else {
                res.Clear();
                res[0] = "Invalid configuration";
                break;
            }
         }
         
         foreach (string s in res) {
            Console.WriteLine(s);
         }
         return new int[1] { 3 };
    }*/
}
