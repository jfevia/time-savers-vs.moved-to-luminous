using System.Windows.Media;

namespace TimeSavers.VS.Comments.Extensions.ColorExtensions
{
    //TODO: move to framework

    public static class ColorExtensions
    {
        public static Brush ToBrush(this System.Drawing.Color color)
            => new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
    }
}