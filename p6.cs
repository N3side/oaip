using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace p6
{
    class Program
    {
        public static Random random = new Random();

        public static double[,] generate_random_matrix(int rows_length, int minValue, int maxValue)
        {
            return generate_random_matrix(rows_length, rows_length, minValue, maxValue);
        }

        public static double[,] generate_random_matrix(int rows_length, int cols_length, int minValue, int maxValue)
        {
            double[,] matrix = new double[rows_length, cols_length];

            for (int i = 0; i < rows_length; i++)
            {
                for (int j = 0; j < cols_length; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

        public static int write_matrix(double[,] matrix)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("{");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(", ");
                }
                Console.Write("}");
                Console.WriteLine("");
            }
            Console.WriteLine("}");
            return 1;
        }

        public static int z1(double[,] matrix)
        {
            // for (int i = 0)

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double total = 0;
            bool stringIsZero = false;

            for (int i = 0; i < rows; i++)
            {
                stringIsZero = false;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        stringIsZero = true;
                    }
                }
                if (!stringIsZero)
                {
                    total++;
                }
            }

            Console.WriteLine("inp:");
            write_matrix(matrix);

            Console.WriteLine($"Кол-во строк где нет ни одного нуля: {total}");

            return 1;
        }

        public static int z2(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
        
            write_matrix(matrix);
        
            Console.WriteLine("https://cs5.pikabu.ru/images/big_size_comm/2015-11_1/1446412978120957259.jpg");
        
            // Собираем все элементы в один массив
            double[] allElems = new double[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    allElems[index++] = matrix[i, j];
                }
            }
        
            double maxVal = double.MinValue;
            bool found = false;
        
            // Проходим по всем уникальным значениям в матрице
            for (int i = 0; i < allElems.Length; i++)
            {
                double current = allElems[i];
                int count = 0;
        
                for (int j = 0; j < allElems.Length; j++)
                {
                    if (allElems[j] == current)
                    {
                        count++;
                    }
                }
        
                if (count > 1 && current > maxVal)
                {
                    maxVal = current;
                    found = true;
                }
            }
        
            if (found)
            {
                Console.WriteLine($"max = {maxVal} — наибольшее число, встречающееся более одного раза");
            }
            else
            {
                Console.WriteLine("Нет чисел, встречающихся более одного раза");
            }
        
            return 1;
        }

        public static int z3(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double total_member = 0;
            double total_week = 0;


            Console.WriteLine("inp = ");
            write_matrix(matrix);

            double[] max_member = new double[2] { 0, 0 };
            double[] max_week = new double[2] { 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                total_member = 0;
                for (int j = 0; j < cols; j++)
                {
                    total_member += matrix[i, j];
                }
                Console.WriteLine($"{i}-ый в семье: [" +

                $"траты за неделю: {total_member}" +
                $"]");

                if (total_member > max_member[1])
                {
                    max_member[0] = i;
                    max_member[1] = total_member;
                }
            }

            for (int j = 0; j < cols; j++)
            {
                total_week = 0;
                for (int i = 0; i < rows; i++)
                {
                    total_week += matrix[i, j];
                }

                if (total_week > max_week[1])
                {
                    max_week[0] = j;
                    max_week[1] = total_week;
                }

                Console.WriteLine($"{j} неделя: [" +
                $"траты за неделю: {total_week}" +
                $"]");
            }

            Console.WriteLine($"Больше всех потратил за месяц {max_member[0]}-ый в семье");
            Console.WriteLine($"Неделя с самыми большими затратами: {max_week[0]}");

            return 1;
        }

        public static int z4(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
        
            write_matrix(matrix);
        
            // Массивы для хранения минимумов строк и максимумов столбцов
            double[] rowMins = new double[rows];
            double[] colMaxs = new double[cols]; 
        
            for (int i = 0; i < rows; i++)
            {
                double min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                rowMins[i] = min;
            }
        
            for (int j = 0; j < cols; j++)
            {
                double max = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
                colMaxs[j] = max;
            }
        
            bool found = false;
            Console.Write("Седловые точки найдены на позициях (строка, столбец): ");
        
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == rowMins[i] && matrix[i, j] == colMaxs[j])
                    {
                        Console.Write($"({i}, {j}) ");
                        found = true;
                    }
                }
            }
        
            if (!found)
            {
                Console.WriteLine("нет");
            }
            else
            {
                Console.WriteLine(); // перенос строки после списка
            }
        
            return 1;
        }

        public static int z5()
        {
            double[,] matrix1 = {
                {1, 2, 1},
                {0, 1, 0},
                {2, 3, 4}
            };

            double[,] matrix2 = {
                {2, 5},
                {6, 7},
                {1, 8}
            };

            write_matrix(matrix1);
            write_matrix(matrix2);

            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);

            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                Console.WriteLine("Матрицы несовместимы для умножения!");
                return -1;
            }

            double[,] result = new double[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            write_matrix(result);
            return 1;
        }

        public static int zblin()
        {
            Console.WriteLine("Введите символ");
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("число");
            } else
            {
                Console.WriteLine("нет");
            }
            
            return 1;
        }

        public static int zblin1()
        {
            Console.WriteLine("Введите 1 букву");
            char letterOne = char.Parse(Console.ReadLine()); ;
            Console.WriteLine("Введите 2 букву");
            char letterTwo = char.Parse(Console.ReadLine());

            if (Char.IsLetter(letterOne) && Char.IsLetter(letterTwo))
            {
                if (letterOne < letterTwo)
                {
                    for (int i = letterOne; i <= letterTwo; i++)
                    {
                        Console.WriteLine((char)i);
                    }

                } else if (letterOne > letterTwo)
                {
                    for (int i = letterOne + 1; i>letterTwo; i--) {
                        Console.WriteLine((char)i);
                    }
                } else
                {
                    Console.WriteLine("Ты тупой?");
                }
            }

            return 1;
        }

        public static int zblin2()
        {

            Console.WriteLine("Введите символ");
            char a = Char.Parse(Console.ReadLine());

            string result = Char.IsUpper(a) ? "в верхнем" : "в нижнем";

            Console.WriteLine(result);

            return 1;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // z1(generate_random_matrix(random.Next(4, 6), 0, 10));
            // z2(generate_random_matrix(random.Next(5, 7), 0, 1000));
            // z3(generate_random_matrix(5, 4, 200, 10000));
            z4(generate_random_matrix(random.Next(3, 5), random.Next(3, 5), 3, 4));
            // z5();

            // zblin();
            // zblin1();
            // zblin2();
        }
    }
}
