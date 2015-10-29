using System;
using System.Collections.Generic;

namespace Therondels
{
    public class Article
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public string HtmlContent { get; set; }

        public DateTime Date { get; set; }

        public string Author { get; set; }

        public List<string> Pictures { get; set; }
    }
}