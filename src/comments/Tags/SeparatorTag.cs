using Microsoft.VisualStudio.Text.Tagging;

namespace TimeSavers.VS.Comments.Tags
{
    internal class SeparatorTag : ITag
    {
        //***

        public string Content;

        //!!!

        public SeparatorTag(string content)
        {
            Content = content;
        }
        //!!!

        //***
    }
}