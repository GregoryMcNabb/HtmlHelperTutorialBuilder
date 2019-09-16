using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialBuilder
{
    public class TutorialStep
    {
        public string ElementID { get; set; }
        public string Text { get; set; }
        public object HtmlAttributes { get; set; }
    }
}
