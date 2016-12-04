﻿using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.ProjectNode
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class EditProjectCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.EditProjectCommand;

        //!!!

        private EditProjectCommand(PackageBase package) : base(package, CommandId)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditProjectCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
        {
            get
            {
                if (!base.IsActive)
                    return false;

                if (!Package.ProjectIsSelected)
                    return false;

                return SolutionIsNotBuilding;
            }
        }

        //---

        private CommandResult ExecuteCommand()
            => Package?.EditSelectedProject();

        //***
    }
}