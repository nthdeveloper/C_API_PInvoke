using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_API_User
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test SumTwoIntegers
            int sumResult = SimpleDLLHelper.SumTwoIntegers(10, 20);
            Console.WriteLine($"Result of SumTwoIntegers: {sumResult}");

            //Test MultiplyByTwo
            int myNumber = 11;
            SimpleDLLHelper.MultiplyByTwo(ref myNumber);
            Console.WriteLine($"Result of SumTwoIntegers: {myNumber}");

            //Test GetNameLength
            int stringLength = SimpleDLLHelper.GetNameLength("John");
            Console.WriteLine($"Length of the string 'John' is {stringLength}");

            //Test GetFullName
            Console.WriteLine("Full name is " + SimpleDLLHelper.GetFullName("John", "Fox"));

            Console.ReadLine();
        }
    }
}
