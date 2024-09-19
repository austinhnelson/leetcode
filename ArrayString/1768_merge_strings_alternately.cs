public class Solution {
    public string MergeAlternately(string word1, string word2) {
        // assuming equal lengths
        int largestSize = Math.Max(word1.Length, word2.Length);
        StringBuilder sb = new StringBuilder("", largestSize);

        for(int i = 0; i < largestSize; i++){
            if(i < word1.Length){
                sb.Append(word1[i]);
            }
            if(i < word2.Length){
                sb.Append(word2[i]);
            }
        }
        return sb.ToString();
    }
}