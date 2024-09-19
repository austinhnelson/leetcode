public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0;
        int totalSum = 0;

        if (nums == null || nums.Length == 0)
            return -1;

        for(int i = 0; i < nums.Length; i++){
            totalSum += nums[i];
        }

        for(int i = 0; i < nums.Length; i++){
            if(leftSum == totalSum - nums[i] - leftSum){
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}