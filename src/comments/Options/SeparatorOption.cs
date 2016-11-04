using System.ComponentModel;
using System.Drawing;

namespace TimeSavers.VS.Comments.Options
{
    public class SeparatorOption
    {
        public string Name { get; set; }

        [Category("Behavior")]
        public string Matches { get; set; }

        [Category("Appearance")]
        public Color Color { get; set; }

        [Category("Appearance")]
        public double Height { get; set; }
    }
}