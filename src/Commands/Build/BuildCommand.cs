namespace TimeSavers.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Packages;
    using VS.Options;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        //***

        protected BuildDialogPage BuildOptions
            => ((PackageClass)Package).BuildOptions;

        //!!!

        protected BuildCommand(PackageBase package, int id) : base(package, id)
        { }

        //!!!

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.BuildCommandsEnabled);

        //***
    }
}