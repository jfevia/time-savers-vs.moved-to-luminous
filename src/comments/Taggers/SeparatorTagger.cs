using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Shell;

using static System.StringComparison;
using static System.Text.RegularExpressions.RegexOptions;

namespace TimeSavers.VS.Comments.Taggers
{
    using YD.Framework.VisualStudio.Packages;
    using Options;
    using Tags;

    internal sealed class SeparatorTagger : RegexTagger<SeparatorTag>
    {
        //***

        //!!!

        internal SeparatorTagger(ITextBuffer buffer) : base(buffer,
            new[]
            {
                new Regex(SeparatorRegex(), Compiled | CultureInvariant | IgnoreCase)//,
                //new Regex(@"^\s*//(\*\*\*|===|---|!!!)$", Compiled | CultureInvariant | IgnoreCase)
            })
        { }

        //!!!

        protected override SeparatorTag TryCreateTagForMatch(Match match)
            => new SeparatorTag(match.Groups[0].Value);

        //---

        private static string SeparatorRegex()
        {
            const string COMMENT_PREFIX = "//";
            const string REGEX_OR = "|";

            var separators = PackageBase.GetDialogPage<SeparatorsDialogPage>().Separators;
            var keys = separators
                .Where(x => x.Matches.StartsWith(COMMENT_PREFIX, CurrentCultureIgnoreCase))
                .Select(x => Regex.Escape(x.Matches.TrimPrefix(COMMENT_PREFIX)))
                .Aggregate(new StringBuilder(), (current, next)
                    => current
                        .Append(REGEX_OR)
                        .Append(next))
                            .ToString()
                            .TrimPrefix(REGEX_OR);

            return $"^\\s*//({keys})$";
        }

        //***
    }
}