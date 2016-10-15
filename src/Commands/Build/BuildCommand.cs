namespace TimeSavers.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Packages;
    using VS.Options;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        private BuildDialogPage _buildOptions;

        //***

        protected BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = Package?.GetDialogPage(typeof(BuildDialogPage)) as BuildDialogPage);

        //===M

        protected BuildCommand(PackageBase package, int id) : base(package, id)
        { }

        //===M

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.BuildCommandsEnabled);

        //---

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _buildOptions?.Dispose();
                    _buildOptions = null;
                }

                disposedValue = true;
            }

            base.Dispose(disposing);
        }

        //***
    }
}