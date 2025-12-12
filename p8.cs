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

        static int Z1()
        {
            Console.WriteLine("");

            string[] students = {
                "Иванов А.Б.",
                "Петров В.Г.",
                "Сидоров Д.Е.",
                "Иванов К.Л.",
                "Кузнецов М.Н.",
                "Петров С.Т.",
                "Смирнов А.Б.",
                "Иванов Р.С.",
                "Кузнецов О.П.",
                "Сидоров Ф.Х."
            };

            string surname;
            string[] surnames = new string[students.Length];
            string[] uniques = new string[students.Length];


            for (int i = 0; i < students.Length; i++)
            {
                surname = students[i].Split(" ")[0];
                if (surnames.Contains(surname))
                {
                    uniques[i] = surname;
                }
                else
                {
                    surnames[i] = surname;
                }
            }

            Console.Write("{");

            for (int i = 0; i < uniques.Length; i++)
            {
                Console.Write(uniques[i]);

                Console.Write("");
            }

            Console.Write("}");

            return 0;
        }

        static int Z2()
        {

            string[] testInputs = {
                "1010",      // валидно
                "0",         // валидно
                "1",         // валидно
                "1111",      // валидно
                "0000",      // валидно
                "10000001",  // валидно
                "2",         // невалидно
                "102",       // невалидно
                "abc",       // невалидно
                "10 1",      // невалидно
                "1,0,1",     // невалидно
                "",          // невалидно
                "101a",      // невалидно
                " 1010",     // невалидно
                "1010 ",     // невалидно
                "01",        // валидно
                "1010101010101010" // валидно
            };

            foreach (string input in testInputs)
            {

                bool isValid = true;

                foreach (char c in input)
                {
                    if (c != '0' && c != '1')
                    {
                        isValid = false;
                        break;
                    }
                }

                Console.WriteLine(isValid ? "валидно" : "невалидно");
            }

            return 0;
        }



        static int Z3()
        {

            string[] words = { "11 22 33 44 55 66", "Clever student wants to study" };

            Console.WriteLine();

            foreach (string word in words)
            {

                string[] arr = word.Split(" ");

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }

                Console.WriteLine();

                Console.WriteLine($"{arr.Length} слов");
            }

            return 0;
        }

        public static string reverse_string(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static int Z4()
        {

            string s = "шалаш";

            Console.WriteLine(s == reverse_string(s) ? "полиндром" : "не полиндром");

            return 0;
        }

        static int Z5()
        {

            string review = "ДААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА. ЭТО ЖЕ ПРАВИЛЬНАЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯ ЛОГИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИИКААААААААААААААААААААААААААААААААААААА. НАДО ОГРАНИЧИВАТЬ НЕ ДЛИНУ СЛОВА А СЛОВА";

            string[] arr = review.Split(" ");

            string review_ = "";

            for (int i = 0; i < 10; i++)
            {
                review_ += arr[i];
                if (i < 9)
                {
                    review_ += " ";
                }
            }

            Console.WriteLine(review_);

            return 0;
        }



        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Z1();
            // Z2();
            // Z3();
            // Z4();
            Z5();
        }
    }
}