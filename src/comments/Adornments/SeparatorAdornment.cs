using System;
using System.Windows.Controls;
using System.Windows.Media;
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

        //private SeparatorOption[] _separators;

        //private static SeparatorsDialogPage _options;

        //***

        //private string Value { get; }

        //private SeparatorsDialogPage Options
        //    => _options ?? (_options = PackageBase.GetDialogPage<SeparatorsDialogPage>());

        //private SeparatorOption[] Separators
        //    => _separators ?? (_separators = Options.Separators);

        //private SeparatorOption Separator { get; }

        //!!!

        internal SeparatorAdornment(SeparatorTag separatorTag, Action onClick)
        {
            BorderBrush = FrozenBrush(Colors.Transparent);

            _onClick = onClick;

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

            Background = FrozenBrush(separator.Color);
            Height = separator?.Height ?? 0;
            Width = 200;
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