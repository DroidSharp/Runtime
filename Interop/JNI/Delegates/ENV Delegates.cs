using System;
using System.Runtime.InteropServices;

namespace DroidSharp.Interop.JNI.Delegates
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIVersion GetVersion(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate IntPtr DefineClassHandler(IntPtr ENVPtr, IntPtr NamePtr, IntPtr Loader, sbyte* Buffer, int Length);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate IntPtr FindClassHandler(IntPtr ENVPtr, IntPtr NamePtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate IntPtr FromReflectedMethodHandler(IntPtr ENVPtr, IntPtr MethodPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate IntPtr FromReflectedFieldHandler(IntPtr ENVPtr, IntPtr FieldPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate IntPtr ToReflectedMethodHandler(IntPtr ENVPtr, IntPtr ClassPtr, IntPtr MethodIDPtr, byte IsStatic);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate Handler(IntPtr ENVPtr);
}
