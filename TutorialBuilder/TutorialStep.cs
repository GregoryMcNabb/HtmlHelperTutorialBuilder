using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialBuilder
{
    public class TutorialStep
    {
        public TutorialStep(string selector, string text, string title)
        {
            Selector = selector;
            Text = text;
            Title = title;
        }
        [JsonProperty]
        internal string Selector { get; set; }
        [JsonProperty]
        internal string Title { get; set; }
        [JsonProperty]
        internal string Text { get; set; }
    }
}
