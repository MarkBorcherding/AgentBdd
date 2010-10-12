using System;
using System.Collections;
using GrowlUnit.Specs.Support;
using NUnit.Core;
using TechTalk.SpecFlow;

namespace GrowlUnit.Specs.Steps
{
    [Binding]
    public class TestMonitoringSteps
    {
        private GrowlNotifier _growlerNotifier;
/*Given I have a growl notifier
	When my tests results pass
	Then I should see the a success message*/

        [Given(@"I have a growl notifier")]
        public void Given_I_have_a_growl_notifier()
        {
            _growlerNotifier = new GrowlNotifier();
        }

        [When(@"my tests results pass")]
        public void Wiven_my_tests_results_pass()
        {
            _growlerNotifier.RunFinished(new TestResult(new TestInfo(new TestName(){}){}));
        }

        [When(@"my tests results fail")]
        public void Wiven_my_test_results_fail()
        {
            _growlerNotifier.RunFinished(new FakeTestResult{IsFakeFailure = true});
        }

        [When(@"my tests throw an exception")]
        public void Wiven_my_tests_throw_an_exception()
        {
            _growlerNotifier.RunFinished(new Exception());
        }

        [Then(@"I should see the a (?:failure|success) message")]
        public void Then_I_should_see_the_a_failuresuccess_message()
        {
        }
    }
}
