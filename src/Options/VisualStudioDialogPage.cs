using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(VisualStudioDialogPageString)]
    public class VisualStudioDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(H1 + VisualStudioFeatures)]
        [DisplayName(VisualStudioFeatures + Space + Enabled)]
        [Description(EnablesDisablesAll + Space + VisualStudioFeatures)]
        public bool VisualStudioCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + VisualStudioCommands)]
        [DisplayName(ReopenStartPage + Space + Command + Enabled)]
        [Description("Enables the '" + ReopenStartPage + "' command")]
        [DefaultValue(true)]
        public bool ReopenStartPageEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}