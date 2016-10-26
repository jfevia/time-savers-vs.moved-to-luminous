using System.Windows.Controls;

namespace TimeSavers.VS.UI.Controls.InsertGuid
{
    using ToolWindows.InsertGuid;
    using ViewModels.InsertGuid;

    public partial class InsertGuidControl : UserControl
    {
        //***

        //===M

        public InsertGuidControl(InsertGuidToolWindow parent)
        {
            InitializeComponent();

            DataContext = new InsertGuidViewModel();
        }

        //===M

        //***
    }
}