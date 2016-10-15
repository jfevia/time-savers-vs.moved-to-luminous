using Microsoft.VisualStudio.Shell;
using YD.Framework.VisualStudio.Commands;
using YD.Framework.VisualStudio.Packages;

namespace TimeSavers.VS.Commands.SolutionNode
{
    internal sealed class EditSolutionCommand : DynamicCommand
    {
        //***
        //===M

        private EditSolutionCommand(PackageBase package) : base(package, PackageIds.EditSolutionCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditSolutionCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
            => base.IsActive
                && SolutionIsNotBuilding;

        //---

        private CommandResult ExecuteCommand()
            => Package?.EditSolution();

        //***
    }
}