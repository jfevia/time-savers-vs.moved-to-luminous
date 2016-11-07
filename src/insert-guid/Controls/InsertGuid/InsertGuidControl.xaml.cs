using System.Windows.Controls;

namespace TimeSavers.VS.InsertGuid.Controls
{
    using ToolWindows;
    using ViewModels;

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