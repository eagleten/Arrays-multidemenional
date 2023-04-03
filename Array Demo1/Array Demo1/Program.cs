using System;

//WAP to accept 10 numbers in array and print the sum of those numbers

namespace ArrayDemo1
{
    public static class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("Sum of array elements is : {0}", sum);

        }
    }

}
