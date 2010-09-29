using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace AgentBdd.Macros
{
    public abstract class BasicMacro : IMacro
    {
        
        public string GetPlaceholder()
        {
            return "a";
        }

        public bool HandleExpansion(IHotspotContext context, IList<string> arguments)
        {
            return false;
        }

        public HotspotItems GetLookupItems(IHotspotContext context, IList<string> arguments)
        {
            return null;
        }

        public abstract string EvaluateQuickResult(IHotspotContext context, IList<string> arguments);
        

        public abstract ParameterInfo[] Parameters { get; }
        
    }
}
