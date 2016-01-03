using System;
using System.Runtime.InteropServices;

namespace DroidSharp.Interop.JNI.Delegates
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIResult DestroyJavaVMHandler(IntPtr JVMPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIResult AttachCurrentThreadHandler(IntPtr JVMPtr, out IntPtr ENVPtr, IntPtr Options);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIResult DetachCurrentThreadHandler(IntPtr JVMPtr);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIResult GetENVHandler(IntPtr JVMPtr, out IntPtr ENVPtr, JNIVersion Version);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate JNIResult AttachCurrentThreadAsDaemonHandler(IntPtr JVMPtr, out IntPtr ENVPtr, IntPtr Options);
}
