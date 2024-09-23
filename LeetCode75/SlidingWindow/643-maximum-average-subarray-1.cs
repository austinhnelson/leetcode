public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double result = 0;
        double running = 0;

        for(int i = 0; i < k; i++){
            running += nums[i];
        }
        result = running / k;

        for(int i = k; i < nums.Length; i++){
            running += nums[i] - nums[i - k];
            result = Math.Max(result, running/k);
        }

        return result;
    }
}