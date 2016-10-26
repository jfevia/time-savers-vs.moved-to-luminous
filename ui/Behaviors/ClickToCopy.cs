using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TimeSavers.VS.UI.Behaviors
{
    public static class ClickToCopy
    {
        //***

        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsClickToCopyEnabled",
                typeof(bool), typeof(TextBox),
                new PropertyMetadata(false, OnIsClickToCopyEnabledChanged));

        //===

        public static bool GetIsEnabled(TextBox element)
            => (bool)element.GetValue(IsEnabledProperty);

        public static void SetIsEnabled(TextBox element, bool value)
        {
            element.SetValue(IsEnabledProperty, value);
        }

        //===

        private static void OnIsClickToCopyEnabledChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if ((bool)e.NewValue)
            {
                textBox.IsReadOnly = true;
                textBox.IsReadOnlyCaretVisible = false;
                textBox.AutoWordSelection = false;
                textBox.Cursor = Cursors.Hand;
                textBox.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(PreviewMouseLeftButtonUp);
            }
            else
            {
                textBox.IsReadOnly = false;
                textBox.IsReadOnlyCaretVisible = true;
                textBox.AutoWordSelection = true;
                textBox.Cursor = Cursors.Arrow;
                textBox.MouseLeftButtonUp -= new MouseButtonEventHandler(PreviewMouseLeftButtonUp);
            }
        }

        private static void PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText((sender as TextBox).Text);
        }

        //***
    }
}