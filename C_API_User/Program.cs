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
            //Use SumTwoIntegers function in native SimpleDLL.dll file
            int sumResult = SimpleDLLHelper.SumTwoIntegers(10, 20);
            Console.WriteLine($"Result of SumTwoIntegers: {sumResult}");

            int myNumber = 11;
            SimpleDLLHelper.MultiplyByTwo(ref myNumber);
            Console.WriteLine($"Result of SumTwoIntegers: {myNumber}");

            Console.ReadLine();
        }
    }
}
