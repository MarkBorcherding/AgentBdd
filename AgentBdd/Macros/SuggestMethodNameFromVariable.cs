using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace AgentBdd.Macros
{
    [Macro("suggestMethodName", 
        ShortDescription   = "Suggest a method name for {#0:another variable}", 
        LongDescription    = "Suggest a new method name for the given variable")]
    public class SuggestMethodNameFromVariable : BasicMacro
    {

        public override string EvaluateQuickResult(IHotspotContext context, IList<string> arguments)
        {
            if (arguments.Count != 1){
                return null;
            }

            try
            {

                // Todo: do this better and maybe move to offer the space and camel case version
                var result = arguments[0]
                    .Replace(' ','_')
                    .Replace(",","")
                    .Replace("\"","")
                    .Replace("'","");

                return result;
            }
            catch (Exception e)
            {
                return "<" + e.Message + ">";
            }
        }

        public override ParameterInfo[] Parameters
        {
            get { return new[] { new ParameterInfo(ParameterType.VariableReference) };            }
        }
    }
    
}
