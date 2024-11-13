using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        // string output = Regex.Replace(s.ToLower(), @"[^a-zA-Z0-9]", "");
        s = s.ToLower();
        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while(leftIndex < s.Length) {
            if (!Char.IsLetterOrDigit(s[leftIndex])){
                leftIndex++;
                continue;
            }

            if (!Char.IsLetterOrDigit(s[rightIndex])){
                rightIndex--;
                continue;
            }

            if(s[leftIndex] != s[rightIndex]){
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }
}