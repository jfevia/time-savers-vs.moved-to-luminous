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
        [DisplayName(Separator + Space + Definitions)]
        [Description("Defines the separator's Name, Matches, Color and Height")]
        public SeparatorOption[] Separators { get; set; } = new SeparatorOption[]
        {
            new SeparatorOption {
                Name = "Class Separator", Matches = "//***", Color = Color.FromArgb(255, 129, 189, 144), Height = 2
            },
            new SeparatorOption {
                Name = "Constructor Separator", Matches = "//!!!", Color = Color.Magenta, Height = 1.5
            },
            new SeparatorOption {
                Name = "Major Separator", Matches = "//===", Color = Color.LightGreen, Height = 1.5
            } ,
            new SeparatorOption {
                Name = "Minor Separator", Matches = "//---", Color = Color.LightSeaGreen, Height = 0.5
            }
        };

        //***
    }
}