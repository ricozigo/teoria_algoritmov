//задание 3


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static int MinJumps(int[] nums)
//    {
//        int n = nums.Length;
//        if (n == 1)
//            return 0;

//        bool[] visited = new bool[n];
//        visited[0] = true;

//        Queue<(int index, int jumps)> queue = new Queue<(int, int)>();
//        queue.Enqueue((0, 0));

//        while (queue.Count > 0)
//        {
//            var current = queue.Dequeue();
//            int currentIndex = current.index;
//            int currentJumps = current.jumps;

//            for (int j = 1; j <= nums[currentIndex]; j++)
//            {
//                int nextIndex = currentIndex + j;

//                if (nextIndex >= n)
//                    break;

//                if (!visited[nextIndex])
//                {
//                    if (nextIndex == n - 1)
//                        return currentJumps + 1;

//                    visited[nextIndex] = true;
//                    queue.Enqueue((nextIndex, currentJumps + 1));
//                }
//            }
//        }

//        return -1;
//    }

//    static void Main()
//    {
//        int[] nums = { 2, 3, 1, 1, 4 };
//        int result = MinJumps(nums);

//        Console.WriteLine("Minimum jumps: " + result);
//    }
//}



//задание 4 

using System;
class Program
{
    static void Main()
    {

        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        RotateMatrix(matrix);

        Console.WriteLine("\nПовернутая матрица:");
        PrintMatrix(matrix);
    }

    static void RotateMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);


        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n - 1 - j];
                matrix[i, n - 1 - j] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
