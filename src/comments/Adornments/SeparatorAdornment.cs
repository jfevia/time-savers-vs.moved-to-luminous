using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace TimeSavers.VS.Comments.Adornments
{
    using YD.Framework.VisualStudio.Packages;
    using Tags;
    using Options;

    using static PackageConstants;

    internal sealed class SeparatorAdornment : Button
    {
        private readonly Action _onClick;

        private SeparatorOption[] _separators;

        private static SeparatorsDialogPage _options;

        //***

        private string Value { get; }


        public SeparatorsDialogPage Options
            => _options ?? (_options = PackageBase.GetDialogPage<SeparatorsDialogPage>());


        public SeparatorOption[] Separators
            => _separators ?? (_separators = Options.Separators);

        //!!!

        internal SeparatorAdornment(SeparatorTag separatorTag, Action onClick)
        {
            Value = separatorTag.Content.Trim();
            BorderBrush = FrozenBrush(Colors.Transparent);

            _onClick = onClick;

            Update();
        }

        //!!!

        protected override void OnClick()
        {
            _onClick();
        }

        internal void Update()
        {
            Background = SeparatorBrush();
            Height = SeparatorHeight();
            Width = SeparatorWidth();
        }

        //===

        private Brush FrozenBrush(Color color)
        {
            var brush = new SolidColorBrush(color);

            brush.Freeze();

            return brush;
        }

        private Brush SeparatorBrush()
        {
            var separator = Separators.FirstOrDefault(x => x.Matches == Value);
            var color = separator?.Color ?? Colors.Red;

            return FrozenBrush(color);
        }

        private double SeparatorHeight()
        {
            var separator = Separators.FirstOrDefault(x => x.Matches == Value);

            return (separator?.Height ?? 0);
        }

        private double SeparatorWidth()
            => 200;

        //***
    }
}