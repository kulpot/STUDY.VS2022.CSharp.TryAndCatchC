using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 4;
            int num2 = 2;
            int result;

            

            try
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Can't devide by zero!");
            }


            try
            {
                int userInputAsInt = int.Parse(userInput);/// for error cause numbers only
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally //for internet connection/database/bluetooth/etc
            {
                Console.WriteLine("This is called anyways!");
            }

            //int userInputAsInt = int.Parse(userInput);

            Console.ReadKey();

        }
    }
}