using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.InsertGuid.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(SeparatorsDialogPageString)]
    public class SeparatorsDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(SeparatorsFeature)]
        [DisplayName(SeparatorsFeature + Space + Enabled)]
        [Description(EnablesDisables + Space + SeparatorsFeature)]
        public bool SeparatorsCommandsEnabled { get; set; } = true;

        //***
    }
}