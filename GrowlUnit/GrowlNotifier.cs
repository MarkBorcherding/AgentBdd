using System;
using Growl.Connector;
using GrowlUnit.NotificationTypes;
using NUnit.Core.Extensibility;
using NUnit.Core;

namespace GrowlUnit
{

    [NUnitAddin(Name="Growl Unit",
                Description="An add in to broadcast test success and failure to Growl for Windows."
               )]
    public class GrowlNotifier : IAddin, EventListener
    {
        private readonly IGrowler _growler;

        public GrowlNotifier() 
            : this(new Growler("Growl Unit", new NotificationType[]{new SuccessNotification(),new FailureNotification()})){}

        public GrowlNotifier(IGrowler growler)
        {
            _growler = growler;
        }

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
            _growler.Notify(exception.FormatGrowlMessage());
        }

        public void RunFinished(TestResult result)
        {
            _growler.Notify(result.FormatGrowlMessage());
        }

        public void RunStarted(string name, int testCount){}
        public void SuiteFinished(TestResult result){}
        public void SuiteStarted(TestName testName){}
        public void TestFinished(TestResult result){}
        public void TestOutput(TestOutput testOutput){}
        public void TestStarted(TestName testName){}
        public void UnhandledException(Exception exception){}
    }
}
