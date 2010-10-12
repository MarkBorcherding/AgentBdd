using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Growl.Connector;
using TechTalk.SpecFlow;

namespace GrowlUnit.Specs.Steps
{
    [Binding]
    public class GrowlSteps
    {
        private Growler _growler;
        private string _applicationName;
        private Dictionary<string,string> _notificationTypes = new Dictionary<string, string>();

        [Given(@"I have a growl application with the name of ""(.*)""")]
        public void Given_I_have_a_growl_application_with_the_name_of(string applicationName)
        {
            _applicationName = applicationName;            
        }

        [Given(@"there it has a notification type of ""(.*)"" with and id of ""(.*)""")]
        public void Given_there_it_has_a_notification_type_of_with_and_id_of(string messageDescription, string messageId)
        {
            _notificationTypes.Add(messageId,messageDescription);
        }

        [Given(@"the Growl application is registered")]
        public void Given_the_Growl_application_is_registered()
        {
            var types = _notificationTypes.Select(x=>new NotificationType(x.Key,x.Value)).ToArray();
            _growler = new Growler(_applicationName, types);
        }

        [When(@"I send a ""(.*)"" message ""(.*)"" with a title ""(.*)""")]
        public void Wiven_I_send_a_message_with_a_title(string messageType, string message, string title)
        {
            _growler.Notify(new Notification(_applicationName,messageType,DateTime.Now.Ticks.ToString(),title,message));
        }

        [Then(@"you should have see it pop up")]
        public void Then_you_should_have_see_it_pop_up()
        {
        }


    }
}
