using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(DeveloperDialogPageString)]
    public class DeveloperDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(H1 + DeveloperFeatures)]
        [DisplayName(DeveloperFeatures + Space + Enabled)]
        [Description(EnablesDisablesAll + Space + DeveloperFeatures)]
        public bool DeveloperCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + DeveloperCommands)]
        [DisplayName(ActivityLog + Space + Command + Enabled)]
        [Description("Enables the '" + ActivityLog + "' command")]
        [DefaultValue(true)]
        public bool ActivityLogCommandEnabled { get; set; } = true;

        [Category(H2 + DeveloperCommands)]
        [DisplayName(DiagnosticsLog + Space + Command + Enabled)]
        [Description("Enables the '" + DiagnosticsLog + "' command")]
        [DefaultValue(true)]
        public bool DiagnosticLogCommandEnabled { get; set; } = true;

        [Category(H2 + DeveloperCommands)]
        [DisplayName(PathVariables + Space + Command + Enabled)]
        [Description("Enables the '" + PathVariables + "' command")]
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