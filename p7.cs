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
            char l = 'f';

            bool isHex = "0123456789ABCDEFabcdef".Contains(l); //

            Console.WriteLine(isHex ? "Да" : "Нет");

            return 0;
        }

       static int Z2()
       {
            char[] arr = { 'a', 'b', 'c', 'd', 'A', 'B', 'C', 'D', 'Z' };



            Console.Write("{ ");

            int[] bordersUpper = { 65, (int)('Z') };
            int[] bordersLower = { 97, 122 };

            int offset = 3;
             
            for (int i = 0; i < arr.Length; i++)
            {


                int ci = (int)arr[i];

                bool isUpper = ci >= bordersUpper[0] && ci <= bordersUpper[1];
                bool isLower = ci >= bordersLower[0] && ci <= bordersLower[1];

                int product;

                if (isUpper)
                {
                    if (ci + offset > bordersUpper[1])
                    {
                        product = bordersUpper[0] - 1 + (ci + offset - bordersUpper[1]);
                    }
                    else
                    {
                        product = ci + offset;
                    }
                } else if (isLower)
                {
                    if (ci + offset > bordersLower[1])
                    {
                        product = bordersLower[0] - 1 + (ci + offset - bordersLower[1]);
                    }
                    else
                    {
                        product = ci + offset;
                    }
                } else
                {
                    product = ci;
                }



                char c = (char)product;
                Console.Write($"{c}, ");

            }

            Console.Write("}");

            return 0; 
       }

        static int Z3()
        {

            string s = "'[',[,],{[,],},(,[,(,),]),')'";

            char[,] arr = { { '{', '}' }, { '(', ')' }, { '[', ']' } };

            int count = 0;

            for (int i = 0; i< arr.GetLength(0); i++)
            
                count += Math.Min(s.Split(arr[i, 0]).Length - 1, s.Split(arr[i, 1]).Length - 1);

            Console.WriteLine(count);

            return 0;
        }

        static void Main(string[] args)
        {
            //Z1();
            // Z2();
            // Z3();
        }
    }
}
