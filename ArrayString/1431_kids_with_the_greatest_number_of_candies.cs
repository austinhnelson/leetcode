public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int greatestCandy = 0;
        List<bool> result = new List<bool>();
        for(int i = 0; i < candies.Length; i++) {
            if (candies[i] > greatestCandy){
                greatestCandy = candies[i];
            }
        }

        for (int i = 0; i < candies.Length; i++){
            if (candies[i] + extraCandies >= greatestCandy){
                result.Add(true);
            }
            else {
                result.Add(false);
            }
        }
        return result;
    }
}