using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.VisualStudio
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class ExtensionsAndUpdatesCommand : DynamicCommand
    {
        //***
        //===M

        private ExtensionsAndUpdatesCommand(PackageBase package) : base(package, PackageIds.ExtensionsAndUpdatesCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new ExtensionsAndUpdatesCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.OpenExtensionsAndUpdates();

        //***
    }
}