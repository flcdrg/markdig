using Textamina.Markdig.Parsers;
using Textamina.Markdig.Parsers.Inlines;

namespace Textamina.Markdig.Syntax.Inlines
{
    public class AutolinkInline : LeafInline
    {
        public bool IsEmail { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return Url;
        }
    }
}