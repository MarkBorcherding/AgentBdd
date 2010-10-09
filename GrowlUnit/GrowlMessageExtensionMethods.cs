using System;
using NUnit.Core;

namespace GrowlUnit
{
    public static class GrowlMessageExtensionMethods
    {
        public static GrowlMessage FormatGrowlMessage(this Exception @this)
        {
            return new GrowlMessage
                       {
                           Title = "Oh noz!",
                           Message = "We suck."
                       };
        }

        public static GrowlMessage FormatGrowlMessage(this TestResult @this)
        {
            return new GrowlMessage
                       {
                           Title = "Yo",
                           Message = "We are growling."
                       };
        }
    }
}
