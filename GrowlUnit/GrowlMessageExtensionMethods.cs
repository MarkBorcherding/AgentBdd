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
            if(@this.IsSuccess) {
                return new Notification(applicationName:"Growl Unit", 
                                        notificationName:SuccessNotification.NotificationName, 
                                        id:Guid.NewGuid().ToString(),
                                        title:"Awesome!",
                                        text:"You Rock.");   
            }

            if(@this.IsFailure)
            {
                return new Notification(applicationName:"Growl Unit", 
                                        notificationName:FailureNotification.NotificationName, 
                                        id:Guid.NewGuid().ToString(),
                                        title:"Ruh Roh!",
                                        text:"You suck.");    
            }

            return new Notification(applicationName:"Growl Unit", 
                                    notificationName:FailureNotification.NotificationName, 
                                    id:Guid.NewGuid().ToString(),
                                    title:"Who knows!",
                                    text:"Go figure this out fool!");
        }
    }
}
