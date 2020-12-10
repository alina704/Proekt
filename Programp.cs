using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long M2, M11, M22, R, MAX, dat, res, N;
            M2 = 0; // самое большое число кратное 2, но не кратное 11
            Log("M2 = " + M2.ToString() + '\n');
            M11 = 0; //самое большое число кратное 11, но не кратное 2
            Log("M11 = " + M11.ToString() + '\n');
            M22 = 0; // самое большое число кратное 22
            Log("M22 = " + M22.ToString() + '\n');
            MAX = 0; // самое большое число среди всех элементов последовательности
            Log("MAX = " + MAX.ToString() + '\n');

            N = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                dat = Convert.ToInt64(Console.ReadLine());
                if ((dat % 2 == 0) && (dat % 11 > 0) && dat > M2)// самое большое число кратное 2
                {
                    M2 = dat;
                    Log("M2 = " + M2.ToString() + '\n'); 
                }
                if (dat % 11 == 0 && dat % 2 > 0 && dat > M11) // самое большое число кратное 11
                {
                    M11 = dat;
                    Log("M11 = " + M11.ToString() + '\n');
                }
                if (dat % 11 == 0 && dat > M22) // кратное 22
                {
                    if (M22 > MAX)
                    {
                        MAX = M22;
                        M22 = dat;
                        Log("M22 = " + M22.ToString() + '\n'); // нахождение самого большого числа среди всех
                    }
                }
                else
                {
                    if (dat > MAX)
                        MAX = dat;
                    Log("MAX = " + MAX.ToString() + '\n'); // нахождение самого большого числа 
                }

                R = Convert.ToInt64(Console.ReadLine());
                if (M2 * M11 < M22 * MAX)
                {
                    res = M22 * MAX; //нахождение результата
                    Log("Результат = " + res.ToString() + '\n');
                    Console.WriteLine($"Вычисленное контрольное значение {i}: {res}");

                    if (R == res)
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }

                }
                else
                {

                    res = M2 * M11; // нахождение результата
                    Log("Результат = " + res.ToString() + '\n');
                    Console.WriteLine($"Вычисленное контрольное значение {i}: {res}");

                    if (R == res)
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }
                }
            }
        }

        private static void Log1(string message)
        {
            try
            {
                File.AppendAllText("D:\\log.txt", message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }



        }

        private static void Log(string v)
        {
            throw new NotImplementedException();
        }
    }
}