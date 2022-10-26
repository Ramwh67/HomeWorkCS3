using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {   
            int palindrom(int num)
            {
                string str = num.ToString();
                int[] array = new int[str.Length];
                int flag = 0;
                
                for(int i=0; i<str.Length; i++)
                {
                    array[i] = int.Parse(str[i].ToString());
                } 

                for(int i=0; i<array.Length; i++)
                {
                    if (array[i] != array[array.Length-1-i])
                    {
                            flag = 1;
                            break;
                    }
                }
                
                return flag;
            }

            Console.Write("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            if (palindrom(number) == 1) Console.WriteLine("Число не является полиндромом ");
            else Console.WriteLine("Число является полиндромом");
           

        }
    }
}