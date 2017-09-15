using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employeedispose
{
        class BaseClass : IDisposable
        {
            // Flag: Has Dispose already been called?
            bool disposed = false;
            // Instantiate a SafeHandle instance.
            //SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

            // Public implementation of Dispose pattern callable by consumers.
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            // Protected implementation of Dispose pattern.
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                if (disposing)
                {
                    //handle.Dispose();
                    Console.WriteLine("resources are cleanedup");
                    // Free any other managed objects here.
                    //
                }

                // Free any unmanaged objects here.
                //
                disposed = true;
            }
        }
    }

