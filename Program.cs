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



           



            //Напишите программу, которая находит наименьшее из нескольких целых. Полагайте,
            //что первое прочитанное число задает количество последующих вводимых чисел.

            Console.WriteLine("Программа по поиску наименшего числа");
            Console.WriteLine("Введите кол-во чисел для сравнения: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int x = 1;

            for (int p = 1; a <= 1; p++)
            {
                Console.WriteLine("Введите кол-во чисел, РАВНОЕ ИЛИ БОЛЕЕ ДВУХ, для сравнения: ");
                a = Convert.ToInt32(Console.ReadLine());
            }           

            Console.WriteLine("Вам предстоит ввести " + a + " чисел.");

            Console.WriteLine("Введите первое число: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int q = Convert.ToInt32(Console.ReadLine());

            if (q < w)
            {
                x = q;
            }

            else
            {
                x = w;
            }

            for (int b = 3; b <= a; b++)
            {
                Console.WriteLine("Введите следующее число: ");
                int e = Convert.ToInt32(Console.ReadLine());

               if (e < x)
                {
                    x = e;
                }

               else
                {
                    continue;
                }

            }

            Console.WriteLine("Наименьшее число - " + x);




             




            //Напишите программу, которая считает и печатает произведение не­ четных целых от 1 до 15.

            Console.WriteLine("Программа, которая считает и печатает произведение не­ четных целых от 1 до 15.");

            int z = 1;

             for (int x = 1; x <= 15; x++)
            {
                if ((x % 2) > 0)
                    {
                        z = x * z;
                    }                
            }

            Console.WriteLine(z);



            



            //Одно из интересных приложений компьютеров — рисование диа­ грамм и гистограмм.
            //Напишите программу, которая читает пять чисел (каждое между 1 и 30).
            //Для каждого просчитанного числа ваша программа должна напечатать строку,
            //содержащую соответ­ ствующее число смежных звездочек.
            //Например, если ваша програм­ ма прочла число 7, она должна напечатать *******,

            Console.WriteLine("Вам сейчас нужно будет ввести пять чисел. Каждое должно быть в диапазоне от 1 до 30");

            int x = 0;
            int n1;
            int n2;
            int n3;
            int n4;
            int n5;
            string q = "*";



            do
            {
                Console.WriteLine("Введите ПЕРВОЕ число в диапазоне от 1 до 30: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x < 1 || x > 30);

            n1 = x;



            do
            {
                Console.WriteLine("Введите ВТОРОЕ число в диапазоне от 1 до 30: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x < 1 || x > 30);

            n2 = x;



            do
            {
                Console.WriteLine("Введите ТРЕТЕЕ число в диапазоне от 1 до 30: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x < 1 || x > 30);

            n3 = x;



            do
            {
                Console.WriteLine("Введите ЧЕТВЁРТОЕ число в диапазоне от 1 до 30: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x < 1 || x > 30);

            n4 = x;



            do
            {
                Console.WriteLine("Введите ПЯТОЕ число в диапазоне от 1 до 30: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x < 1 || x > 30);

            n5 = x;



            for (int z = 1; z <= n1; z++)
            {
                Console.Write(q);
            }

            Console.Write("\n");


            for (int z = 1; z <= n2; z++)
            {
                Console.Write(q);
            }

            Console.Write("\n");

            for (int z = 1; z <= n3; z++)
            {
                Console.Write(q);
            }

            Console.Write("\n");

            for (int z = 1; z <= n4; z++)
            {
                Console.Write(q);
            }

            Console.Write("\n");

            for (int z = 1; z <= n5; z++)
            {
                Console.Write(q);
            }




            */




            //Разработайте программу на C++, которая должна определять заработную плату для каждого из нескольких служащих.
            //Компания выплачивает каждому служащему повременную зарплату за первые 40 часов работы и выплачивает в полуторном
            //размере за все рабочие часы сверх 40. Вам дан список сотрудников компании, число часов, отработанных каждым
            //за последнюю неделю, и почасовая ставка каждого сотрудника. Программа должна ввести эти данные для каждого сотрудника,
            //рассчитать и вывести на экран его суммарную зарплату.

            




        }
    }
}