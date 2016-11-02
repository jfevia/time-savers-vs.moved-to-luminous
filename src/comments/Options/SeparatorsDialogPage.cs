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
        //===M
        //===M

        [Category(H1 + SeparatorsFeature)]
        [DisplayName(Enable + Space + SeparatorsFeature)]
        [Description("Allows the " + PackageConstants.Separators + " feature to be turned off")]
        public bool SeparatorsCommandsEnabled { get; set; } = true;

        [Category(H2 + Definitions)]
        [DisplayName(PackageConstants.Separator + Space + Definitions)]
        [Description("Defines the separator's Name, Matches, Color and Height")]
        public Separator[] Separators { get; set; } = new Separator[]
        {
            new Separator {
                Name = "Class", Matches = "//***", Color = Color.FromArgb(255, 129, 189, 144), Height = 4
            },
            new Separator {
                Name = "Constructor", Matches = "//!!!", Color = Color.Magenta, Height = 2
            },
            new Separator {
                Name = "Major Method", Matches = "//===", Color = Color.Green, Height = 2
            } ,
            new Separator {
                Name = "Minor Method", Matches = "//---", Color = Color.Blue, Height = 1
            }
        };

        //***
    }
}