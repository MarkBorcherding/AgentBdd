using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
                return MethodNameFromString(arguments[0]);
            }
            catch (Exception e)
            {
                return "<" + e.Message + ">";
            }
        }

        private static string MethodNameFromString(string s)
        {
            s = RemoveTheSymbols(s);
            s = ConvertSpacesToUnderscores(s);            
            return s;
        }

        private static string RemoveTheSymbols(string s)
        {
            return Regex.Replace(s,@"[^A-Za-z0-9_\s]",string.Empty,RegexOptions.None);
        }

        private static string ConvertSpacesToUnderscores(string s)
        {
            return Regex.Replace(s,@"\s+","_",RegexOptions.None);
        }



        public override ParameterInfo[] Parameters
        {
            get { return new[] { new ParameterInfo(ParameterType.VariableReference) };            }
        }
    }
    
}
