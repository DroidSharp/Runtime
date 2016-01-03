using System;
using System.Runtime.InteropServices;

namespace DroidSharp.Interop
{
    internal class AnsiString : DisposableBase
    {
        #region Variables
        private IntPtr _stringPtr;
        #endregion

        #region Properties
        public IntPtr StringPtr { get { return _stringPtr; } }
        #endregion

        #region Constructors
        public AnsiString(string String)
        {
            _stringPtr = Marshal.StringToHGlobalAnsi(String);
        }
        #endregion

        #region Functions
        protected override void DisposeResources()
        {
            Marshal.FreeHGlobal(_stringPtr);
        }
        #endregion
    }
}
