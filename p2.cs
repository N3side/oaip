using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int lovitdajenaparkovke()
            {
                Console.WriteLine("Ваше имя");
                string name = Console.ReadLine();
                Console.WriteLine($"Привет, {name}. Какая температура на улице?");
                double temp = double.Parse(Console.ReadLine());
                string answer = temp >= 20 ? "Сегодня погода норм" : "Сегодня плохая погода";
                Console.WriteLine(answer);
                return 1;
            }
            int z2()
            {
                Console.WriteLine("Введите a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c");
                double x = double.Parse(Console.ReadLine());

                double y = Math.Sqrt(a + b) < x
                    ? (a * Math.Pow(x, 2) + b * Math.Log10(Math.Abs(2 * x)))
                    : (Math.Sqrt(a + Math.Sin(2 * x)));
                Console.Write($"y = {y}");
                return 1;
            }
            int z3()
            {
                Console.WriteLine("Введите N");
                double N = double.Parse(Console.ReadLine());
                string answer = N % 5 != 0 && N % 2 == 0 && N % 3 == 0 ?
                    "Да" : "Нет";
                Console.WriteLine(answer);

                return 1;
            }
            int z4()
{
    Console.WriteLine("Введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите R");
    double R = double.Parse(Console.ReadLine());

    double distance = Math.Sqrt(x * x + y * y);

    string answer = distance <= R ? "Да" : "Нет";

    Console.WriteLine($"Точка ({x}, {y}) {(answer == "Да" ? "лежит" : "не лежит")} внутри окружности радиуса {R}.");

    return 1;
}

            
            int z5() {
                Console.WriteLine("Введите номер недели: ");
                int weekIndex = int.Parse(Console.ReadLine());
                string week = "";
                switch (weekIndex) {
                    case 1:
                        week = "Понедельник";
                        break;
                    case 2:
                        week = "Вторник";
                        break;
                    case 3:
                        week = "Среда";
                        break;
                    case 4:
                        week = "Четверг";
                        break;
                    case 5:
                        week = "Пятница";
                        break;
                    case 6:
                        week = "Суббота";
                        break;
                    case 7:
                        week = "Воскресенье";
                        break;
                    default:
                        week = "Не правильные вводимые данные";
                        break;
                }
                
                Console.WriteLine(week);
                return 1;
            }
            
            int dop()
            {
                for (int th = 2; th < 10; th++) {
                    Console.Write($"{th} ");
                }
                
                Console.WriteLine("");
                
                for (int i = 2; i < 10; i++) {
                    for (int j = 1; j < 10; j++) {
                        Console.Write($"{i * j} ");
                    }
                    Console.WriteLine("");
                }

                return 1;
            }

            dop();
            
        }
    }
}
