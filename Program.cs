using System;

namespace Лекция_5_Кожанов
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1");
            int[] mas = new int[6];
            //Console.WriteLine(mas);
            for(int i=0;i<6;i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Задача №2");
            Console.WriteLine("Элменты в обратном порядке:");
            for ( int i=6-1; i>=0; i--)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Задача №3");
            int sum = 0;
            for(int i=0;i<6;i++)
            {
                if (mas[i]%2==0)
                {
                    sum += mas[i];
                }    
            }
            Console.WriteLine("Сумма чётных элементов массива равна: "+sum);
            Console.WriteLine("Задача №4");
            int min;
            min = mas[0];
            for (int i = 1; i < 6; i++)
            {
                if (mas[i]<min)
                {
                    min = mas[i];
                }
            }
            Console.WriteLine("Минимальное число в массиве = " + min);
        }
    }
}
