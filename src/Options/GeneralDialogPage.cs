using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(PackageGuids.GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(TimeSaversFeatures)]
        [DisplayName(TimeSaversFeatures + Space + Enabled)]
        [Description(EnablesDisablesAll + Space + TimeSaversFeatures)]
        public bool TimeSaversEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}