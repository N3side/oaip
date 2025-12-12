using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace p7
{
    internal class Program
    {

        static Random random = new Random();

        public static int fact(int x)
        {

            int result = 1;

            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }

        static int Z1()
        {
            int k = 5;
            int n = 7;

            int result = fact(n) / (fact(k) * fact(n - k));

            Console.WriteLine(result);

            return 0;
        }

        public static double[] generate_random_array(int min, int max)
        {
            int arr_length = random.Next(5, 16);
            double[] arr = new double[arr_length];

            for (int i = 0; i < arr.Length; i++)
            {
                int rand_n = random.Next(min, max);
                arr[i] = rand_n;
            }

            return arr;
        }

        public static string string_array(double[] array)
        {
            string s = "{";
            for (int i = 0; i < array.Length; i++)
            {
                s += $"{array[i]}, ";
            }
            s += "}";

            return s;
        }

        public static double get_avg(double[] arr)
        {
            double avg = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }

            avg = avg / arr.Length;

            return avg;
        }

        public static int get_cou_where_elem_more_than_avg(double[] arr, double avg)
        {

            int cou = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg) cou++;
            }

            return cou;

        }

        static int Z2()
        {

            double[] arr = generate_random_array(10, 100);

            Console.WriteLine(string_array(arr));

            double avg = get_avg(arr);

            Console.WriteLine($"avg = {avg}");
            Console.WriteLine($"cou = {get_cou_where_elem_more_than_avg(arr, avg)}");

            return 0;
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



        static double[] sort(double[] arr, string param = "asc")
        {
            double buffed;

            if (param == "asc")
            {
                //по возврастанию
                for (int i = arr.Length; i >= 1; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            buffed = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = buffed;
                        }
                    }
                }
            }
            else
            {
                //по убыванию
                for (int i = arr.Length; i >= 1; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            buffed = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = buffed;
                        }
                    }
                }
            }

            return arr;
        }

        public static double[,] FormatMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[,] newMatrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                // 1. Извлекаем строку в одномерный массив
                double[] row = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }

                // 2. Сортируем
                double[] sortedRow;
                if (i % 2 == 0)
                {
                    sortedRow = sort(row, "asc");
                }
                else
                {
                    sortedRow = sort(row, "desc");
                }

                // 3. Записываем обратно в новую матрицу
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[i, j] = sortedRow[j];
                }
            }

            return newMatrix;
        }

        static int Z3()
        {

            double[,] matrix = generate_random_matrix(5, 5, 10, 100);

            write_matrix(matrix);

            double[,] sorted = FormatMatrix(matrix);

            write_matrix(sorted);

            return 0;
        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Z1();
            // Z2();
            // Z3();
        }
    }
}
