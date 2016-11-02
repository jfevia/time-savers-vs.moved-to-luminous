using System.ComponentModel;
using System.Drawing;

namespace TimeSavers.VS.Comments.Options
{
    public class Separator
    {
        public string Name { get; set; }

        [Category("Behavior")]
        public string Matches { get; set; }

        [Category("Appearance")]
        public Color Color { get; set; }

        [Category("Appearance")]
        public int Height { get; set; }
    }
}