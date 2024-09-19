public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var list1 = new HashSet<int>();
        var list2 = new HashSet<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!nums2.Contains(nums1[i]))
            {
                list1.Add(nums1[i]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (!nums1.Contains(nums2[i]))
            {
                list2.Add(nums2[i]);
            }
        }

        return
        [
            [.. list1],
            [.. list2]
        ];
    }
}