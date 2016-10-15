using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageConstants;

    [Guid(PackageGuids.GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(Vsix.Name + " " + Features)]
        [DisplayName(Vsix.Name + " " + Enabled)]
        [Description("All features for the " + Vsix.Name + " package")]
        public bool TimeSaversEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}