using System;
using Growl.Connector;
using GrowlUnit.NotificationTypes;
using NUnit.Core;

namespace GrowlUnit
{
    public static class GrowlMessageExtensionMethods
    {
        public static Notification FormatGrowlMessage(this Exception @this)
        {
            return new Notification(applicationName:"Growl Unit", 
                                    notificationName:FailureNotification.NotificationName, 
                                    id:DateTime.Now.Ticks.ToString(),
                                    title:"Ruh Roh!",
                                    text:"You suck.");
        }

        public static Notification FormatGrowlMessage(this TestResult @this)
        {
            return new Notification(applicationName:"Growl Unit", 
                                    notificationName:SuccessNotification.NotificationName, 
                                    id:DateTime.Now.Ticks.ToString(),
                                    title:"Awesome!",
                                    text:"You Rock.");   
        }
    }
}
