using System;

using DroidSharp.Interop.JNI.Delegates;

namespace DroidSharp.Interop.JNI
{
    internal class JVM
    {
        #region Variables
        private IntPtr _pointer;

        private DestroyJavaVMHandler _destroyJavaVM;
        private AttachCurrentThreadHandler _attachCurrentThread;
        private DetachCurrentThreadHandler _detachCurrentThread;
        private GetENVHandler _getENV;
        private AttachCurrentThreadAsDaemonHandler _attachCurrentThreadAsDaemon;
        #endregion

        #region Constructors
        public JVM(IntPtr JVMPtr)
        {
            _pointer = JVMPtr;

            unsafe
            {
                var functions = **(JNIInvokeInterface**)JVMPtr.ToPointer();

                _destroyJavaVM = FunctionHelper.GetDelegate<DestroyJavaVMHandler>(functions.DestroyJavaVM);
                _attachCurrentThread = FunctionHelper.GetDelegate<AttachCurrentThreadHandler>(functions.AttachCurrentThread);
                _detachCurrentThread = FunctionHelper.GetDelegate<DetachCurrentThreadHandler>(functions.DetachCurrentThread);
                _getENV = FunctionHelper.GetDelegate<GetENVHandler>(functions.GetEnv);
                _attachCurrentThreadAsDaemon = FunctionHelper.GetDelegate<AttachCurrentThreadAsDaemonHandler>(functions.AttachCurrentThreadAsDaemon);
            }
        }
        #endregion

        #region Functions
        #endregion
    }
}
