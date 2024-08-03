public class RemoveDuplicates
{

    public Action Run = () =>
    {
        int[] nums = new int[] { 1, 1, 2 };
        Console.WriteLine(RemoveDupes(nums));
    };
    public static int RemoveDupes(int[] nums)
    {
        int[] uniqueNums = new HashSet<int>(nums).ToArray();

        Array.Copy(uniqueNums, nums, uniqueNums.Length);

        return uniqueNums.Length;
    }
}