using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(BuildDialogPageString)]
    public class BuildDialogPage : DialogPage
    {
        //***
        //===M
        //===M

        [Category(H1 + Build + " " + Features)]
        [DisplayName(Build + " " + FeaturesEnabled)]
        [Description("Rebuild Solution, Rebuild Project, Cancel Build")]
        public bool BuildCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + Build + " " + Commands)]
        [DisplayName("Rebuild Solution Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool RebuildSolutionCommandEnabled { get; set; } = true;

        [Category(H2 + Build + " " + Commands)]
        [DisplayName("Rebuild Project Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool RebuildProjectCommandEnabled { get; set; } = true;

        [Category(H2 + Build + " " + Commands)]
        [DisplayName("Cancel Build Enabled")]
        [Description("")]
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