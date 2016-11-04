using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace TimeSavers.VS.Comments.Options
{
    using static PackageGuids;
    using static PackageConstants;

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
                Name = "Class", Matches = "//***", Color = Color.FromArgb(255, 129, 189, 144), Height = 3
            },
            new SeparatorOption {
                Name = "Constructor", Matches = "//!!!", Color = Color.Magenta, Height = 2
            },
            new SeparatorOption {
                Name = "Major Method", Matches = "//===", Color = Color.LightGreen, Height = 2
            } ,
            new SeparatorOption {
                Name = "Minor Method", Matches = "//---", Color = Color.Blue, Height = 1
            }
        };

        //***
    }
}