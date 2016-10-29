using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;
using System;
using System.ComponentModel.Composition;

namespace TimeSavers.VS.Comments.Providers
{
    using Tags;
    using Taggers;

    [Export(typeof(ITaggerProvider))]
    [ContentType("text")]
    [TagType(typeof(SeparatorTag))]
    internal sealed class SeparatorTaggerProvider : ITaggerProvider
    {
        public ITagger<T> CreateTagger<T>(ITextBuffer buffer)
            where T : ITag
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            return buffer.Properties.GetOrCreateSingletonProperty(() =>
                new SeparatorTagger(buffer)) as ITagger<T>;
        }
    }
}