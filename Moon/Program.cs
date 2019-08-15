using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер карты");

            string userInput = Console.ReadLine();

            int parityOfNumber = userInput.Length;

            int summResult;
            int result = 0;

            if (parityOfNumber % 2 == 0)
            {

                for (int i = 0; i < parityOfNumber; i++)
                {
                    int a = Int16.Parse(new string(userInput[i], 1));

                    if (i % 2 == 0)
                    {
                        if (a * 2 > 9)
                        {
                            result += 2 * a - 9;
                        }

                        else
                        {
                            result += a * 2;
                        }

                    }
                    else
                    {
                        result += a;
                    }




                }

            }
            else
            {
                for (int i = 0; i < parityOfNumber; i++)
                {
                    int a = Int16.Parse(new string(userInput[i], 1));

                    if (i % 2 != 0)
                    {
                        if (a * 2 > 9)
                        {
                            result += 2 * a - 9;
                        }

                        else
                        {
                            result += a * 2;
                        }

                    }
                    else
                    {
                        result += a;
                    }
                }
                Console.WriteLine(result);

                Console.ReadKey();


            }
        }

    }
}
