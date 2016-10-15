using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Restart
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RestartElevatedCommand : DynamicCommand
    {
        //***
        //===M

        private RestartElevatedCommand(PackageBase package) : base(package, PackageIds.RestartElevatedCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartElevatedCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio(elevated: true);

        //***
    }
}