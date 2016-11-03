using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Comments.Options
{
    using static PackageGuids;
    using static PackageConstants;
    using System.Windows.Media;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(SeparatorsDialogPageString)]
    public class SeparatorsDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(H1 + SeparatorsFeature)]
        [DisplayName(Enable + Space + SeparatorsFeature)]
        [Description("Allows the " + PackageConstants.Separators + " feature to be turned off")]
        public bool SeparatorsCommandsEnabled { get; set; } = true;

        [Category(H2 + Definitions)]
        [DisplayName(PackageConstants.Separator + Space + Definitions)]
        [Description("Defines the separator's Name, Matches, Color and Height")]
        public SeparatorOption[] Separators { get; set; } = new SeparatorOption[]
        {
            new SeparatorOption {
                Description = "Class", Matches = "//***", Color = Color.FromArgb(255, 129, 189, 144), Height = 4
            },
            new SeparatorOption {
                Description = "Constructor", Matches = "//!!!", Color = Colors.Magenta, Height = 2
            },
            new SeparatorOption {
                Description = "Major Method", Matches = "//===", Color = Colors.Green, Height = 2
            } ,
            new SeparatorOption {
                Description = "Minor Method", Matches = "//---", Color = Colors.Blue, Height = 1
            }
        };

        //***
    }
}