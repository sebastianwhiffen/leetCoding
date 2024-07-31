public class MergeSortedArray
{
    public Action Run = () => 
    {
        int[] nums1 = new int[] {1, 2, 3, 0, 0, 0};
        int m = 3;
        int[] nums2 = new int[] {2, 5, 6};
        int n = 3;

        Merge(nums1, m, nums2, n);
    }; 
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int nums2Index = 0;

        for(int i = m; i < m + n; i++)
        {
            nums1[i] = nums2[nums2Index];

            nums2Index++;
        }

        Array.Sort(nums1);
        Console.WriteLine(string.Join(",", nums1));
    }
}

//you are given two arrays sorted in ascending order, 
//merge the two arrays into a single array in ascending order
//merge to the indexes defined in m and n
//m represents the first array and n represents the second
//store the merged array in the first array that was given 