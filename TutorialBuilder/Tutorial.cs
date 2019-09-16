using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialBuilder
{
    public class Tutorial
    {
        public Dictionary<int, TutorialStep> Steps { get; private set; }

        public string TriggerButtonID { get; set; }
        public string FunctionName { get; set; } = "BeginTutorial";
    }
}
