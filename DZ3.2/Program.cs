using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
           double SegmentLength(int multidimension)
           {

                if(multidimension > 1)
                {
                    double[] a = new double[multidimension];
                    double[] b = new double[multidimension];
                    
                    for (int i = 0; i < multidimension; i++)
                    {
                        Console.Write($"Введите координату {i+1}-ю координату 1-й точки: ");
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    for (int i = 0; i < multidimension; i++)
                    {
                        Console.Write($"Введите координату {i+1}-ю координату 2-й точки: ");
                        b[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    double d = 0;

                    for (int i = 0; i < multidimension; i++)
                    {
                         d += Math.Pow(b[i] - a[i], 2);
                    }
                    d = Math.Sqrt(d);
                    return d;                                   
                 }

                else return -1;

           }

                Console.Write("Введите количество измерений в пространстве ");
                int mult = Convert.ToInt32(Console.ReadLine());
                double result = SegmentLength(mult);

                if (result == -1) Console.WriteLine($"{mult}-мерного пространства не существует. Введите число больше 1");
                else Console.WriteLine($"Расстояние между двумя точками в {mult}-мерном пространстве равно {result}");
        }
    }
}