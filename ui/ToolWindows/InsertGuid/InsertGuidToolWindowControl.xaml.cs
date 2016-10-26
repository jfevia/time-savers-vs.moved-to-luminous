using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace TimeSavers.VS.UI.ToolWindows.InsertGuid
{
    public partial class InsertGuidToolWindowControl : UserControl
    {
        //***

        public Guid NewGuid { get; set; } = new Guid();

        //===M

        public InsertGuidToolWindowControl()
        {
            InitializeComponent();
        }

        //===M

        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "InsertGuidToolWindow");
        }

        //***
    }
}