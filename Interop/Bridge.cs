using System;

using DroidSharp.Interop.JNI;

namespace DroidSharp.Interop
{
    public static class Bridge
    {
        #region Variables
        private static JVM _jvm = null;
        #endregion

        #region Functions
        public static void Initialize(IntPtr JVMPtr)
        {
            Log.I("Loading JVM...");
            _jvm = new JVM(JVMPtr);
        }
        #endregion
    }
}
