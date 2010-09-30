using System.Linq;
using AgentBdd.Macros;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AgentBdd.Specs.Steps
{
    [Binding]
    public class SuggestMethodNameSteps
    {
        string suggestedMethodName;

        [When(@"I provide the step ""(.*)""")]
        public void When_I_provide_the_step(string step)
        {
            suggestedMethodName = new SuggestMethodNameFromVariable().EvaluateQuickResult(null,new []{step}.ToList());
        }

        [Then(@"it should suggest (.*) as the method name")]
        public void Then_it_should_sugget_the_method_name(string methodName)
        {
            Assert.AreEqual(methodName,suggestedMethodName);
        }


    }
}
