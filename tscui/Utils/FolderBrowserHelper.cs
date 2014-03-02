using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Utils
{
    class FolderBrowserHelper: System.Windows.Forms.IWin32Window
        {
            IntPtr _handle;
            public FolderBrowserHelper(IntPtr handle)
            {
                _handle = handle;
            }

            #region IWin32Window Members
            IntPtr System.Windows.Forms.IWin32Window.Handle
            {
                get { return _handle; }
            }
            #endregion
        }
}
