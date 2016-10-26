﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.UI.ToolWindows.InsertGuid
{
    using Controls.InsertGuid;

    [Guid("776cdc3d-f8f4-4819-8141-cf5938c4cd7d")]
    public class InsertGuidToolWindow : ToolWindowPane
    {
        public InsertGuidToolWindow() : base(null)
        {
            Caption = "Insert Guid";
            BitmapResourceID = 301;
            BitmapIndex = 1;
            Content = new InsertGuidControl(this);
        }
    }
}