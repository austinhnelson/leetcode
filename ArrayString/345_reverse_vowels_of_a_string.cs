public class Solution {
    public string ReverseVowels(string s) {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var input = s.ToCharArray();
        int left = 0;
        int right = input.Length - 1;
        while (left < right){
            while(left < right && !vowels.Contains(input[left])){
                left++;
            }

            while(left < right && !vowels.Contains(input[right])){
                right--;
            }

            if(left < right){
                char temp = input[left];
                input[left] = input[right];
                input[right] = temp;
                left++;
                right--;
            }
        }
        return new string(input);
    }
}