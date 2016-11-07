#define HIDING_TEXT

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

#if HIDING_TEXT
        : IntraTextAdornmentTagTransformer<SeparatorTag, SeparatorAdornment>
#else
        : IntraTextAdornmentTagger<SeparatorTag, SeparatorAdornment>
#endif

    {
        internal static ITagger<IntraTextAdornmentTag> GetTagger(IWpfTextView view, Lazy<ITagAggregator<SeparatorTag>> SeparatorTagger)
        {
            return view.Properties.GetOrCreateSingletonProperty<SeparatorAdornmentTagger>(
                () => new SeparatorAdornmentTagger(view, SeparatorTagger.Value));
        }

#if HIDING_TEXT
        private SeparatorAdornmentTagger(IWpfTextView view, ITagAggregator<SeparatorTag> SeparatorTagger)
            : base(view, SeparatorTagger)
        {
        }

        public override void Dispose()
        {
            base.view.Properties.RemoveProperty(typeof(SeparatorAdornmentTagger));
        }
#else
        private ITagAggregator<SeparatorTag> SeparatorTagger;

        private SeparatorAdornmentTagger(IWpfTextView view, ITagAggregator<SeparatorTag> SeparatorTagger)
            : base(view)
        {
            this.SeparatorTagger = SeparatorTagger;
        }

        public void Dispose()
        {
            SeparatorTagger.Dispose();

            view.Properties.RemoveProperty(typeof(SeparatorAdornmentTagger));
        }

        // To produce adornments that don't obscure the text, the adornment tags
        // should have zero length spans. Overriding this method allows control
        // over the tag spans.
        protected override IEnumerable<Tuple<SnapshotSpan, PositionAffinity?, SeparatorTag>> GetAdornmentData(NormalizedSnapshotSpanCollection spans)
        {
            if (spans.Count == 0)
                yield break;

            ITextSnapshot snapshot = spans[0].Snapshot;

            var SeparatorTags = SeparatorTagger.GetTags(spans);

            foreach (IMappingTagSpan<SeparatorTag> dataTagSpan in SeparatorTags)
            {
                NormalizedSnapshotSpanCollection SeparatorTagSpans = dataTagSpan.Span.GetSpans(snapshot);

                // Ignore data tags that are split by projection.
                // This is theoretically possible but unlikely in current scenarios.
                if (SeparatorTagSpans.Count != 1)
                    continue;

                SnapshotSpan adornmentSpan = new SnapshotSpan(SeparatorTagSpans[0].Start, 0);

                yield return Tuple.Create(adornmentSpan, (PositionAffinity?)PositionAffinity.Successor, dataTagSpan.Tag);
            }
        }
#endif

        protected override SeparatorAdornment CreateAdornment(SeparatorTag data, SnapshotSpan span)
            => new SeparatorAdornment(data, () => OnSpanClick(span));

        protected override bool UpdateAdornment(SeparatorAdornment adornment, SeparatorTag dataTag)
        {
            adornment.Update(dataTag);
            return true;
        }

        private void OnSpanClick(SnapshotSpan span)
        {
            view.Caret.MoveTo(span.Start);
            DisableTag(span);
        }
    }
}