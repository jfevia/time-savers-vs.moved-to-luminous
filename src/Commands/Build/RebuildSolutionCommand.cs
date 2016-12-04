using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RebuildSolutionCommand : BuildCommand
    {
        //***
        //!!!

        private RebuildSolutionCommand(PackageBase package) : base(package, PackageIds.RebuildSolutionCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildSolutionCommand(package));

        //---

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.RebuildSolutionCommandEnabled);

        protected override bool IsActive
            => base.IsActive && SolutionHasProjects && SolutionIsNotBuilding;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.BuildSolution(rebuild: true);

        //***
    }
}