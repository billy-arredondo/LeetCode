namespace LeetCode.Core.Problems.P0002_SumMedianArrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int totalLength = nums1.Length + nums2.Length;
        int[] merged = new int[totalLength];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] <= nums2[j])
            {
                merged[k++] = nums1[i++];
            }
            else
            {
                merged[k++] = nums2[j++];
            }
        }

        while (i < nums1.Length)
        {
            merged[k++] = nums1[i++];
        }

        while (j < nums2.Length)
        {
            merged[k++] = nums2[j++];
        }

        if (totalLength % 2 == 1)
        {
            return merged[totalLength / 2];
        }

        int right = totalLength / 2;
        int left = right - 1;

        return (merged[left] + merged[right]) / 2.0;
    }
}
