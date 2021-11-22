using System;

class MainClass
{



    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] result = new int[nums.Length];
        int n = nums.Length;

        int temp = 0;
        for (int i = 0; i < n; i++)
        {
            temp = nums[i] + temp;
            result[i] = temp;
        }

        /*
        for (int i = 1; i < n; i++)
        {
            nums[i] += nums[i - 1];
        }
        */

        foreach (var item in result)
        {
            Console.Write(item);
        }
    }

}