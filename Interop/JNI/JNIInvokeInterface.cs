using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace DroidSharp.Interop.JNI
{
    [StructLayout(LayoutKind.Sequential), NativeCppClass]
    internal struct JNIInvokeInterface
    {
        public IntPtr __Reserved0;
        public IntPtr __Reserved1;
        public IntPtr __Reserved2;

        public IntPtr DestroyJavaVM;
        public IntPtr AttachCurrentThread;
        public IntPtr DetachCurrentThread;
        public IntPtr GetEnv;
        public IntPtr AttachCurrentThreadAsDaemon;
    }
}
