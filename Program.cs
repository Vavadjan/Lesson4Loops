﻿using System.Globalization;

namespace Lesson4Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine(i);
             }

             for (int i = 0, j = 10; i < j; i++, j--)
             {
                 Console.WriteLine(i + ", " + j);
             }
            */
            /*int i = 0;
            for (; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }*/


            /*
            
            for (int i = 0; i < 10; i++) 
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           

            Console.WriteLine("Enter yor number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= size) // Внешний цикл отвечает за ось Х - 
            {
                if (i == 1 || i == size)
                {
                    int j = 1;
                    while (j <= size)      // Внутренний цикл отвечает за отображение оси Y                  
                    {
                        Console.Write("*");
                        j++;
                    }
                }
                else 
                {
                    int j = 1;
                    while (j <= size)
                    {
                        if (j==1 || j == size)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                        j++;
                    }
                }
                Console.WriteLine();
                  i++;/
            }


             

            //      1       2       3       4       5
            //1     *       *       *       *       *
            //2     *       *       *       *       *
            //3     *       *       *       *       *
            //4     *       *       *       *       *
            //5     *       *       *       *       *


            

            Console.Write("На сколько цифр рисовать таблицу?");
            int yyy = Convert.ToInt32(Console.ReadLine());

            Console.Write("\t");

            for (int xxx = 1; xxx <= yyy; xxx++)
            {
                Console.Write(xxx + "\t");
            }

            Console.Write("\n");
            string zzz = ("\t*");

            for (int xxx = 1 ; xxx <= yyy; xxx++)
            {
                Console.Write(xxx);

                for (int b = 1; b <= yyy; b++)
                {
                    Console.Write(zzz);
                }

                Console.Write("\n");
            }




            




            // рисуем треугольник с пустотой внутри

            Console.WriteLine("Введи длинну катета рисуемого треугольника: ");
            int uu = Convert.ToInt32(Console.ReadLine());

            string tt = "*";
            string kk = "x";

            for (;uu <= 0;)
            {                
                Console.Write("Та не... Напиши норм цифру! От 1 до 30, например!");
                uu = Convert.ToInt32(Console.ReadLine());
            }           
                Console.Write("\n"+tt +"\n");

            for (int s = 1; uu >= 2 && s <= uu - 2; s++)
            {
                Console.Write(tt);
                
                for (int m = uu - s; s >= 2 && m < uu - 1 ;m++)
                {
                    Console.Write(kk);
                }

                Console.Write(tt+"\n");
            }

            for (int dd = 1; uu >=3 && dd <= uu; dd++)
            {
                Console.Write(tt);
            }
            Console.Write("\n");



            



            //Напишите программу, которая постоянно печатает степени целого числа 2, соответственно
            //2, 4, 8, 16, 32, 64 и т.д. Число повторений вашего цикла не должно быть определено
            //(т.е. вы должны создать бесконечный цикл). Что случилось, когда вы выполнили эту про­ грамму?

            long zxc = 2;
            for (int v = 1; zxc >= 0; v++)
            {
                Console.WriteLine(zxc);
                zxc = zxc * zxc;
            }



            */



            //Напишите программу, которая находит наименьшее из нескольких целых. Полагайте,
            //что первое прочитанное число задает количество последующих вводимых чисел.

            Console.WriteLine("Программа по поиску наименшего числа");
            Console.WriteLine("Введите кол-во чисел для сравнения: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int z = 999999;
            int x = 1;

            Console.WriteLine("Вам предстоит ввести " + a + " чисел.");

            for (int b = 1; b <= a; b++)
            {
                Console.WriteLine("Введите число: ");
                int q = Convert.ToInt32(Console.ReadLine());
                int qq = q;

                for (int c = 1; b <= a; c++)
                {
                    if (q < z && qq < q)
                    {
                        x = q;
                    }
                    break;
                }
            }

            Console.WriteLine("Наименьшее число - " + x);





        }
    }
}