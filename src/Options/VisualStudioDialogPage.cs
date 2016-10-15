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

        [Category(H1 + VisualStudio + " " + Features)]
        [DisplayName(VisualStudio + " " + FeaturesEnabled)]
        [Description("Rebuild Project, Rebuild Solution, Cancel Build")]
        public bool VisualStudioCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + VisualStudio + " " + Commands)]
        [DisplayName("Activity Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool ActivityLogCommandEnabled { get; set; } = true;

        [Category(H2 + VisualStudio + " " + Commands)]
        [DisplayName("Diagnostics Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool DiagnosticLogCommandEnabled { get; set; } = true;

        [Category(H2 + VisualStudio + " " + Commands)]
        [DisplayName("Path Variables Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool PathVariablsCommandEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}