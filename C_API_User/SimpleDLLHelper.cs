using System;
using System.Runtime.InteropServices;

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

        //Get a struct by reference
        [DllImport("SimpleDLL.dll", CallingConvention = CallingConvention.Cdecl), System.Security.SuppressUnmanagedCodeSecurity]
        public static extern void ModifyStruct(ref SampleStruct pStruct);
    }

    public enum SampleEnum
    {
        SampleOption1,
        SampleOption2
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SampleStruct
    {
        public int ANumber;
        public SampleEnum AnEnum;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] AnArray;
    }
}
