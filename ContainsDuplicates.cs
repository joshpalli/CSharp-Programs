using System;

// This class takes in an integer array, and returns a boolean if it contains duplicate numbers.
public class ContainsDuplicates
{
    // Create a method to detect if array has duplicates.
    public static bool Duplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) 
                {
                    Console.WriteLine("This Array has duplicates!!");
                    return true;
                }
            }
        }
        return false;
    }

    // Make a Driver method to test function.
    public static void Main(string[] args)
    {
        int[] nums = {3, 2, 3, 4};
        Duplicate(nums);
    }
}
