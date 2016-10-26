﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

//using static Microsoft.VisualStudio.Shell.Interop.SVsShell;
using static Microsoft.VisualStudio.Shell.Interop.UIContextGuids80;

namespace TimeSavers.VS
{
    using YD.Framework.VisualStudio.Packages;
    using Commands.Insert;
    using Commands.Build;
    using Commands.VisualStudio;
    using Commands.Restart;
    using Commands.Options;
    using Commands.SolutionNode;
    using Commands.ProjectNode;
    using Commands.Developer;
    using Options;

    using static PackageConstants;
    using static PackageGuids;
    using static Vsix;
    using Events;
    using Microsoft.VisualStudio.Shell.Interop;

    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(PackageString)]

    [ProvideAutoLoad(NoSolution)]
    [ProvideAutoLoad(SolutionExists)]

    [ProvideOptionPage(typeof(GeneralDialogPage), Name, General, 0, 0, !SupportsAutomation)]
    [ProvideOptionPage(typeof(BuildDialogPage), Name, Build, 0, 0, !SupportsAutomation)]
    [ProvideOptionPage(typeof(DeveloperDialogPage), Name, Developer, 0, 0, !SupportsAutomation)]
    [ProvideOptionPage(typeof(VisualStudioDialogPage), Name, VisualStudio, 0, 0, !SupportsAutomation)]

    public sealed class PackageClass : PackageBase
    {
        private BuildDialogPage _buildOptions;
        private VisualStudioDialogPage _visualStudioOptions;

        //***

        public BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = GetDialogPage(typeof(BuildDialogPage)) as BuildDialogPage);

        public VisualStudioDialogPage VisualStudioOptions
            => _visualStudioOptions ?? (_visualStudioOptions = GetDialogPage(typeof(VisualStudioDialogPage)) as VisualStudioDialogPage);

        //===M

        public PackageClass() : base(PackageCommandSet, Name, Description)
        { }

        //===M

        protected override void Initialize()
        {
            base.Initialize();

            InstantiateInsertCommands();
            InstantiateBuildCommands();
            InstantiateDeveloperCommands();
            InstantiateVisualStudioCommands();
            InstantiateRestartCommands();
            InstantiateOptionsCommands();
            InstantiateSolutionCommands();
            InstantiateProjectCommands();

            AdviseSolutionEvents(new VsSolutionEvents(this));
        }

        //===

        private void InstantiateProjectCommands()
        {
            EditProjectCommand.Instantiate(this);
        }

        private void InstantiateSolutionCommands()
        {
            EditSolutionCommand.Instantiate(this);
            CloseSolutionCommand.Instantiate(this);
        }

        private void InstantiateOptionsCommands()
        {
            KeyboardOptionsCommand.Instantiate(this);
            TimeSaversOptionsCommand.Instantiate(this);
        }

        private void InstantiateRestartCommands()
        {
            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);
        }

        private void InstantiateVisualStudioCommands()
        {
            ExtensionsAndUpdatesCommand.Instantiate(this);
        }

        private void InstantiateDeveloperCommands()
        {
            ActivityLogCommand.Instantiate(this);
            DiagnosticLogCommand.Instantiate(this);
            PathVariablesCommand.Instantiate(this);
        }

        private void InstantiateBuildCommands()
        {
            RebuildProjectCommand.Instantiate(this);
            RebuildSolutionCommand.Instantiate(this);
            CancelBuildCommand.Instantiate(this);
        }

        private void InstantiateInsertCommands()
        {
            InsertGuidCommand.Instantiate(this);
        }

        //TODO: move to framework
        private void AdviseSolutionEvents(IVsSolutionEvents vsSolutionEvents)
        {
            uint solutionEventsCookie;
            var vsSolution = GetGlobalService<SVsSolution, IVsSolution>();

            vsSolution.AdviseSolutionEvents(vsSolutionEvents, out solutionEventsCookie);
        }

        //***
    }
}