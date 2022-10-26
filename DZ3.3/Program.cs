using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {   
            int[] cube(int n)
            {
                  
                int[] cubes = new int[n];
                for (int i = 0; i < n; i++)
                {
                    cubes[i] = (i+1)*(i+1)*(i+1);
                }
                return cubes;
                
            }
            Console.Write("Введите положительно целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Введённое число должно быть больше 0 ");
            }
            else 
            {
                int[] array = cube(num);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
          
        }
    }
}