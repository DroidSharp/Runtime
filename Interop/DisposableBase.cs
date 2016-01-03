using System;

namespace DroidSharp.Interop
{
    internal abstract class DisposableBase : IDisposable
    {
        #region Variables
        private bool _disposed = false;
        #endregion

        #region Destructors
        ~DisposableBase()
        {
            DisposeResources();
        }
        #endregion

        #region Functions
        protected abstract virtual void DisposeResources();

        public void Dispose()
        {
            if (!_disposed)
            {
                _disposed = true;
                DisposeResources();
                GC.SuppressFinalize(this);
            }
        }
        #endregion
    }
}
