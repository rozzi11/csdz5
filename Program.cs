// 1.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[4]; 
//         int countEven = 0; 

//         Random random = new Random(); 


//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(100, 1000);
//             Console.Write($"{array[i]} "); 
//         }


//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             {
//                 countEven++;
//             }
//         }

//         Console.WriteLine($"\nКоличество четных чисел: {countEven}");

//         Console.ReadLine();
//     }
// }

// 2.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {

//         int[] nums = new int[10];
//         Random rand = new Random();
//         for (int i = 0; i < 10; i++)
//         {
//             nums[i] = rand.Next(100);
//         }


//         int sum = 0;
//         for (int i = 1; i < nums.Length; i += 2)
//         {
//             sum += nums[i];
//         }


//         Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
//         Console.ReadLine();
//     }
// }

// 3.

internal class Program
{
    private static void Main(string[] args)
    {
        double[] arr = { 3, 7, 22, 2, 78 };

        double min = arr[0];
        double max = arr[0];

        foreach (double num in arr)
        {
            if (num < min)
            {
                min = num;
            }
            else if (num > max)
            {
                max = num;
            }
        }

        double diff = max - min;
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
    }
}