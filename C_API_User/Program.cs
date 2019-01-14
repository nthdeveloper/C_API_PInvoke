using System;

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

            //Test ModifyStruct
            SampleStruct myStruct = new SampleStruct();
            myStruct.ANumber = 3;
            myStruct.AnEnum = SampleEnum.SampleOption1;
            myStruct.AnArray = new int[2];
            myStruct.AnArray[0] = 10;

            SimpleDLLHelper.ModifyStruct(ref myStruct);
            Console.WriteLine($"New number is {myStruct.ANumber}, option is {myStruct.AnEnum}, first array item is {myStruct.AnArray[0]}");

            //Test callback function
            ProgressCallback progCallback = (val)=>
            {
                Console.WriteLine($"Progress is {val}");
            };

            SimpleDLLHelper.CallPassedFunction(progCallback);

            Console.ReadLine();
        }
    }
}
