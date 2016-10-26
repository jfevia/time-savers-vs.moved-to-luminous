using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.UI.ToolWindows.InsertGuid
{
    [Guid("776cdc3d-f8f4-4819-8141-cf5938c4cd7d")]
    public class InsertGuidToolWindow : ToolWindowPane
    {
        public InsertGuidToolWindow() : base(null)
        {
            this.Caption = "Insert Guid";
            this.BitmapResourceID = 301;
            this.BitmapIndex = 1;
            this.Content = new InsertGuidToolWindowControl();
        }
    }
}