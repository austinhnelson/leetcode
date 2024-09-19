public class Solution {
    public void MoveZeroes(int[] nums) {
        int itr = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[itr++] = nums[i];
            }
        }

        for (int i = itr; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}