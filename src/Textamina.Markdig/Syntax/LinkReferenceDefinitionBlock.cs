﻿using Textamina.Markdig.Helpers;

namespace Textamina.Markdig.Syntax
{
    public class LinkReferenceDefinitionBlock : LeafBlock
    {
        public LinkReferenceDefinitionBlock() : base(null)
        {
            IsOpen = false;
        }

        public LinkReferenceDefinitionBlock(string label, string url, string title) : this()
        {
            Label = label;
            Url = url;
            Title = title;
        }

        public string Label { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public static bool TryParse<T>(ref ICharIterator text, out LinkReferenceDefinitionBlock block) where T : ICharIterator
        {
            block = null;
            string label;
            string url;
            string title;

            if (!LinkHelper.TryParseLinkReferenceDefinition(ref text, out label, out url, out title))
            {
                return false;
            }

            block = new LinkReferenceDefinitionBlock(label, url, title);
            return true;
        }
    }
}