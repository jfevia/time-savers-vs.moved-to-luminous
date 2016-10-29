using System;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;

namespace TimeSavers.VS.Comments.Taggers
{
    using Tags;
    using Adornments;
    using Transformers;

    internal sealed class SeparatorAdornmentTagger
        : IntraTextAdornmentTagTransformer<SeparatorTag, SeparatorAdornment>
    {
        internal static ITagger<IntraTextAdornmentTag> GetTagger(IWpfTextView view, Lazy<ITagAggregator<SeparatorTag>> separatorTagger)
            => view.Properties.GetOrCreateSingletonProperty(()
                => new SeparatorAdornmentTagger(view, separatorTagger.Value));

        private SeparatorAdornmentTagger(IWpfTextView view, ITagAggregator<SeparatorTag> separatorTagger)
            : base(view, separatorTagger)
        {
        }

        public override void Dispose()
        {
            view.Properties.RemoveProperty(typeof(SeparatorAdornmentTagger));
        }

        protected override SeparatorAdornment CreateAdornment(SeparatorTag separatorTag, SnapshotSpan span)
            => new SeparatorAdornment(separatorTag, () => OnSpanClick(span));

        private void OnSpanClick(SnapshotSpan span)
        {
            view.Caret.MoveTo(span.Start);
            DisableTag(span);
        }

        protected override bool UpdateAdornment(SeparatorAdornment adornment, SeparatorTag separatorTag)
        {
            adornment.Update(separatorTag);

            return true;
        }
    }
}