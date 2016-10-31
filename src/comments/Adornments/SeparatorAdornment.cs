using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace TimeSavers.VS.Comments.Adornments
{
    using YD.Framework.VisualStudio.Packages;
    using Tags;

    using static PackageConstants;

    internal sealed class SeparatorAdornment : Button
    {
        private readonly Action _onClick;

        internal SeparatorAdornment(SeparatorTag separatorTag, Action onClick)
        {
            _onClick = onClick;

            BorderBrush = FrozenBrush(Colors.Transparent);

            Update(separatorTag);
        }

        protected override void OnClick()
        {
            _onClick();
        }

        internal void Update(SeparatorTag separatorTag)
        {
            Background = SeparatorBrush(separatorTag);
            Height = SeparatorHeight(separatorTag);
            Width = SeparatorWidth(separatorTag);
        }

        private Brush FrozenBrush(Color color)
        {
            var brush = new SolidColorBrush(color);

            brush.Freeze();

            return brush;
        }

        private Brush SeparatorBrush(SeparatorTag separatorTag)
        {
            var content = separatorTag.Content.TrimStart();

            if (content.Contains("//***"))
            {
                return FrozenBrush(Color.FromArgb(255, 129, 189, 144));
            }

            if (content.Contains("//==="))
            {
                return FrozenBrush(Colors.Green);
            }

            if (content.Contains("//---"))
            {
                return FrozenBrush(Colors.Blue);
            }

            return FrozenBrush(Colors.Red);
        }

        private Color GetColor()
        {
            //getIVSUIShell2
            var dte = PackageBase.GetDte();
            if (dte == null) return Colors.White;

            var prop = dte.Properties[Vsix.Name, InsertGuid].Item("").Value;

            return Colors.Black;
        }

        private double SeparatorHeight(SeparatorTag separatorTag)
        {
            var content = separatorTag.Content.TrimStart();

            if (content.Contains("//***"))
            {
                return 4;
            }

            if (content.Contains("//==="))
            {
                return 2;
            }

            if (content.Contains("//==="))
            {
                return 2;
            }

            return 1;
        }
        private double SeparatorWidth(SeparatorTag separatorTag)
            => 200;
    }
}