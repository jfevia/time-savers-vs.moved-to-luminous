using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TimeSavers.VS.Comments.Adornments
{
    using Tags;

    internal sealed class SeparatorAdornment : Button
    {
        private readonly Action _onClick;
        private readonly Rectangle _rect;

        internal SeparatorAdornment(SeparatorTag separatorTag, Action onClick)
        {
            _onClick = onClick;
            _rect = new Rectangle
            {
                Stroke = Brushes.Transparent,
                StrokeThickness = 0,
                //Stretch = Stretch.Fill
                //Width = 20,
            };

            Content = _rect;
            Update(separatorTag);
        }

        private Brush MakeBrush(Color color)
        {
            var brush = new SolidColorBrush(color);

            brush.Freeze();

            return brush;
        }

        protected override void OnClick()
        {
            _onClick();
        }

        internal void Update(SeparatorTag separatorTag)
        {
            //BorderBrush = MakeBrush(Colors.Transparent);
            //Background = MakeBrush(Color.FromArgb(255, 129, 189, 144));
            //Width = 90;

            _rect.Fill = MakeBrush(Color.FromArgb(255, 129, 189, 144));
            _rect.Width = 80; // separatorTag.Content.Length * 12;
            _rect.Height = 4;
        }
    }
}