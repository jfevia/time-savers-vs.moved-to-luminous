using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(BuildDialogPageString)]
    public class BuildDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(H1 + BuildFeatures)]
        [DisplayName(BuildFeatures + Space + Enabled)]
        [Description(EnablesDisablesAll + Space + BuildFeatures)]
        public bool BuildCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + BuildCommands)]
        [DisplayName(RebuildSolution + Space + Command + Space + Enabled)]
        [Description("Enables the '" + RebuildSolution + "' command")]
        [DefaultValue(true)]
        public bool RebuildSolutionCommandEnabled { get; set; } = true;

        [Category(H2 + BuildCommands)]
        [DisplayName(RebuildProject + Space + Command + Space + Enabled)]
        [Description("Enables the '" + RebuildProject + "' command")]
        [DefaultValue(true)]
        public bool RebuildProjectCommandEnabled { get; set; } = true;

        [Category(H2 + BuildCommands)]
        [DisplayName(CancelBuild + Space + Command + Space + Enabled)]
        [Description("Enables the '" + CancelBuild + "' command")]
        [DefaultValue(true)]
        public bool CancelBuildCommandEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}