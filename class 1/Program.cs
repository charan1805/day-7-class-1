using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            try
            {
                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("Result after adding {0} and {1}=\t {2} ", num1, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
                Console.ReadKey();
            }
        }
    }
}
