using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(DeveloperDialogPageString)]
    public class DeveloperDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(H1 + Developer + " " + Features)]
        [DisplayName(Developer + " " + FeaturesEnabled)]
        [Description("Activity Log, Disgnostics Log, Path Variables")]
        public bool DeveloperCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + Developer + " " + Commands)]
        [DisplayName("Activity Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool ActivityLogCommandEnabled { get; set; } = true;

        [Category(H2 + Developer + " " + Commands)]
        [DisplayName("Diagnostics Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool DiagnosticLogCommandEnabled { get; set; } = true;

        [Category(H2 + Developer + " " + Commands)]
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