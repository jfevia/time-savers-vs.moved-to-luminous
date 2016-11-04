using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Linq;

namespace TimeSavers.VS.Comments.Adornments
{
    using YD.Framework.VisualStudio.Packages;
    using Tags;
    using Options;
    using Extensions.ColorExtensions;

    using static PackageConstants;

    internal sealed class SeparatorAdornment : Button
    {
        private readonly Action _onClick;
        private readonly Rectangle _rect;

        //!!!

        internal SeparatorAdornment(SeparatorTag separatorTag, Action onClick)
        {
            _onClick = onClick;
            _rect = new Rectangle();

            BorderBrush = FrozenBrush(Colors.Transparent);
            Background = FrozenBrush(Colors.Transparent);
            Content = _rect;

            Update(separatorTag);
        }

        //!!!

        protected override void OnClick()
        {
            _onClick();
        }

        internal void Update(SeparatorTag separatorTag)
        {
            var separators = PackageBase.GetDialogPage<SeparatorsDialogPage>().Separators;

            var value = separatorTag.Content.Trim();
            var separator = separators.FirstOrDefault(x => x.Matches == value);

            _rect.Fill = FrozenBrush(separator.Color);
            _rect.Height = separator?.Height ?? 0;
            _rect.Width = 200;
        }

        //===

        private Brush FrozenBrush(Color color)
        {
            var brush = new SolidColorBrush(color);

            brush.Freeze();

            return brush;
        }

        private Brush FrozenBrush(System.Drawing.Color color)
        {
            var brush = color.ToBrush();

            brush.Freeze();

            return brush;
        }

        //***
    }
}