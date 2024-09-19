public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var map = new Dictionary<int, int>();

        // count the number of occurrences of each element
        for(int i = 0; i < arr.Length; i++){
            if(map.ContainsKey(arr[i])){
                map[arr[i]] += 1;
            } else {
                map.Add(arr[i], 1);
            }
        }

        // add occurrences to hash set, ensures each val is unique
        var set = new HashSet<int>();
        foreach(var kvp in map){
            if(!set.Add(kvp.Value)) return false;
        }

        return true;
    }
}