using System;
using NUnit.Core.Extensibility;
using NUnit.Core;

namespace GrowlUnit
{
    public class GrowlNotifier : IAddin, EventListener
    {
        public bool Install(IExtensionHost host)
        {
            var eventListenersPoint = host.GetExtensionPoint("EventListeners");
            if (eventListenersPoint == null)
            {
                return false;
            }

            eventListenersPoint.Install(this);
            return true;
        }

        public void RunFinished(Exception exception)
        {
            
        }

        public void RunFinished(TestResult result)
        {
            
        }

        public void RunStarted(string name, int testCount)
        {
            
        }

        public void SuiteFinished(TestResult result)
        {
        }

        public void SuiteStarted(TestName testName)
        {
        }

        public void TestFinished(TestResult result)
        {
        }

        public void TestOutput(TestOutput testOutput)
        {
        }

        public void TestStarted(TestName testName)
        {
        }

        public void UnhandledException(Exception exception)
        {
        }
    }
}
