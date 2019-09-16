using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TutorialBuilder
{
    internal class Tutorial
    {
        public Tutorial(IEnumerable<TutorialStep> steps, string triggerSelector)
        {
            Steps = steps.ToArray();
            TriggerSelector = triggerSelector;
        }

        public TutorialStep[] Steps { get; private set; }

        public string TriggerSelector { get; set; }
        
        private string GetVariableDefinition()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(Steps);
        }

        public MvcHtmlString Create()
        {
            return new MvcHtmlString($"var tutor = new Tutorial({TriggerSelector},{GetVariableDefinition()})");
        }
    }
}
