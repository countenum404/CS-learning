using System;

namespace OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = MaxRedigit(386);
            Console.WriteLine(a);
        }

        static int MaxRedigit(int threedigitnum)
        {
            int[] nums = new int[3] { threedigitnum / 100, threedigitnum % 100 / 10, threedigitnum % 10};
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums[0]*100 + nums[1]*10 + nums[2];  
        } 
    }
    
}
