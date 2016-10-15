using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Restart
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RestartNormalCommand : DynamicCommand
    {
        //***
        //===M

        private RestartNormalCommand(PackageBase package) : base(package, PackageIds.RestartNormalCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartNormalCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio();

        //***
    }
}