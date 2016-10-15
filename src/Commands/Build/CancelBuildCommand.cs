using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class CancelBuildCommand : BuildCommand
    {
        //***
        //===M

        private CancelBuildCommand(PackageBase package) : base(package, PackageIds.CancelBuildCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new CancelBuildCommand(package));

        //---

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.CancelBuildCommandEnabled);

        protected override bool IsActive
            => base.IsActive && BuildingOrDebugging;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.CancelBuild();

        //***
    }
}