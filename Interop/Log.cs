using System;
using System.Runtime.CompilerServices;

namespace DroidSharp.Interop
{
    internal static class Log
    {
        #region Internal Calls
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void LogI(IntPtr MessagePtr);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void LogE(IntPtr MessagePtr);
        #endregion

        #region Functions
        public static void I(string Message)
        {
            using (var message = new AnsiString(Message))
            {
                LogI(message.StringPtr);
            }
        }

        public static void E(string Message)
        {
            using (var message = new AnsiString(Message))
            {
                LogE(message.StringPtr);
            }
        }
        #endregion
    }
}
