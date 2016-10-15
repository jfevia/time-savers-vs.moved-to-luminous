using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Developer
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    using static YD.Framework.VisualStudio.Commands.CommandKeys;

    internal sealed class ActivityLogCommand : DynamicCommand
    {
        //***

        private string Path
            => $"{Package.UserDataPath}\\ActivityLog.xml";

        //===M

        private ActivityLogCommand(PackageBase package)
            : base(package, PackageIds.ActivityLogCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new ActivityLogCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ExecuteCommand(ViewWebBrowser, Path, problem: "Unable to view activity log");

        //***
    }
}