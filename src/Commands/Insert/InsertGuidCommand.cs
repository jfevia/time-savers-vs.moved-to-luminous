using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace TimeSavers.VS.Commands.Insert
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;
    using InsertGuid.ToolWindows;

    internal sealed class InsertGuidCommand : DynamicCommand
    {
        //***

        //!!!

        private InsertGuidCommand(PackageBase package) : base(package, PackageIds.InsertGuidCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new InsertGuidCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
        {
            var window = Package?.FindToolWindow(typeof(InsertGuidToolWindow), id: 0, create: true);
            if ((null == window) || (null == window.Frame))
            {
                return new ProblemResult("Cannot create tool window");
            }

            var windowFrame = (IVsWindowFrame)window.Frame;
            if (ErrorHandler.Failed(windowFrame.Show()))
            {
                return new ProblemResult("Cannot show tool window");
            }

            return new SuccessResult();

            //return Package?.ReplaceSelectedText(() => NewGuid().ToString(),
            //               problem: "Unable to insert guid");
        }

        //***
    }
}