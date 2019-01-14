using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_API_User
{
    /// <summary>
    /// Helper PInvoke class for calling the methods inside native SimpleDLL.dll file
    /// </summary>
    class SimpleDLLHelper
    {
        //Pass two integer values and get integer
        [DllImport("SimpleDLL.dll", CallingConvention = CallingConvention.Cdecl), System.Security.SuppressUnmanagedCodeSecurity]
        public static extern int SumTwoIntegers(int number1, int number2);

        //Pass a number by reference (pointer)
        [DllImport("SimpleDLL.dll", CallingConvention = CallingConvention.Cdecl), System.Security.SuppressUnmanagedCodeSecurity]
        public static extern void MultiplyByTwo(ref int originalNumber);

        //Pass a unicode strings, return its length
        [DllImport("SimpleDLL.dll", CallingConvention = CallingConvention.Cdecl), System.Security.SuppressUnmanagedCodeSecurity]
        public static extern int GetNameLength([MarshalAs(UnmanagedType.LPWStr)]string name);

        //Pass a number by reference (pointer)
        [DllImport("SimpleDLL.dll", CallingConvention = CallingConvention.Cdecl), System.Security.SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetFullName([MarshalAs(UnmanagedType.LPWStr)]string firstName, [MarshalAs(UnmanagedType.LPWStr)]string lastName);
    }
}
