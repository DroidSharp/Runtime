using System;
using System.Runtime.InteropServices;

namespace DroidSharp.Interop.JNI
{
    internal static class FunctionHelper
    {
        public static T GetDelegate<T>(IntPtr FunctionPtr)
        {
            return (T)(object)Marshal.GetDelegateForFunctionPointer(FunctionPtr, typeof(T));
        }
    }
}
