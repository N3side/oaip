using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z1()
            {
                Console.Write("days = ");
                int days = int.Parse(Console.ReadLine());
                int pushups = 0;
                for (int i = 1; i <= days; i++)
                {
                    if (i == 1)
                    {
                        pushups += 10;
                    } else {
                        pushups *= 2;
                    }
                }
                Console.WriteLine($"pushups = {pushups}");
                return 1;
            }
            int z2()
            {
                Console.Write("S = ");
                double S = int.Parse(Console.ReadLine());
                Console.Write("M = ");
                double M = int.Parse(Console.ReadLine());
                double percent = 10;
                int years = 0;

                while (M > S)
                {
                    years++;
                    S += ((double)S / 100 * 10);
                }

                Console.WriteLine($"Потребуется {years} лет чтобы превысить M при проценте = {percent}");

                return 1;
            }

            int z3()
            {
                string password = "123";
                string user_password = "";
                int attemps = 0;
                do
                {
                    Thread.Sleep(3000); // Защита от брутфорса
                    Console.Write("password = ");
                    user_password = Console.ReadLine();
                    if (attemps > 2)
                    {
                        Console.WriteLine("Слишком много попыток, попробуйте позже");
                        break;
                    }
                    attemps++;
                }
                while (password != user_password);
                Console.WriteLine("Вы успешно вошли в систему");
                return 1;
            }

            int z4()
            {
                Random rnd1 = new Random(100);
                int random_number = rnd1.Next(0, 20);
                int user_number = 100;


                do
                {
                    Console.Write("Привет, угадай число от 1 до 20: ");
                    user_number = int.Parse(Console.ReadLine());
                    if (random_number != user_number)
                    {
                        Console.WriteLine("Не правильно, попробуй еще раз");
                    } else
                    {
                        Console.WriteLine($"Ура. Загаданное число - {random_number}");
                    }
                } while (random_number != user_number);

                Console.WriteLine("");

                Console.WriteLine(random_number);

                return 1;
            }

            z4();
        }
    }
}
