public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        var subSequence = s.ToList();
        for(int i = 0; i < t.Length; i++){
            if(t[i] == subSequence[0]){
                subSequence.RemoveAt(0);
                if (subSequence.Count == 0) return true;
            }
        }
        return subSequence.Count == 0;
    }
}