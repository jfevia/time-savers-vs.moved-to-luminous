using Microsoft.VisualStudio.Text;
using System.Text.RegularExpressions;

using static System.Text.RegularExpressions.RegexOptions;

namespace TimeSavers.VS.Comments.Taggers
{
    using Tags;

    internal sealed class SeparatorTagger : RegexTagger<SeparatorTag>
    {
        internal SeparatorTagger(ITextBuffer buffer) : base(buffer,
            new[] { new Regex(@"^\s*\/\/(\*\*\*|===|---)$", Compiled | CultureInvariant | IgnoreCase) })
        { }

        protected override SeparatorTag TryCreateTagForMatch(Match match)
            => new SeparatorTag(match.Groups[0].Value);
    }
}