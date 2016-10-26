namespace TimeSavers.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Packages;
    using VS.Options;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        //***

        protected BuildDialogPage BuildOptions
            => ((PackageClass)Package).BuildOptions;

        //===M

        protected BuildCommand(PackageBase package, int id) : base(package, id)
        { }

        //===M

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.BuildCommandsEnabled);

        //***
    }
}