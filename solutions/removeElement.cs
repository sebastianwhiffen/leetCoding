public class RemoveElement
{
    public Action Run = () =>
    {
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        // int[] nums = [3, 2, 2, 3];
        int val = 2;

        Console.WriteLine(Remove(nums, val));
    };

    public static int Remove(int[] nums, int val)
    {
        int k = 0;
        int i = 0;
        foreach (int num in nums)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
            i++;
        }
        return k;
    }
}