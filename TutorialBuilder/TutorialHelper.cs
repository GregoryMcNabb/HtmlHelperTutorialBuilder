using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TutorialBuilder
{
    public static class TutorialHelper
    {
        public static MvcHtmlString Tutorial(this HtmlHelper helper, string triggerSelector, IEnumerable<TutorialStep> steps)
        {
            var tutor = new Tutorial(steps, triggerSelector);
            return tutor.Create();
        }

        public static MvcHtmlString Tutorial(this HtmlHelper<dynamic> helper, string triggerSelector, IEnumerable<TutorialStep> steps)
        {
            var tutor = new Tutorial(steps, triggerSelector);
            return tutor.Create();
        }
    }
}
