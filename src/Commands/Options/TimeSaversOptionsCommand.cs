using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Commands.Options
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;
    using VS.Options;

    internal sealed class TimeSaversOptionsCommand : DynamicCommand
    {
        //***
        //===M

        private TimeSaversOptionsCommand(PackageBase package) : base(package, PackageIds.TimeSaversOptionsCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new TimeSaversOptionsCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ShowOptionsPage<GeneralDialogPage>();

        //***
    }
}