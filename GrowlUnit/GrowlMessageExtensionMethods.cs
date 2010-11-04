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
                                    title:"Fail fail fail!",
                                    text:@this.Message);
        }

        public static Notification FormatGrowlMessage(this TestResult @this)
        {
            if(@this.IsSuccess) {
                return new Notification(applicationName:"Growl Unit", 
                                        notificationName:SuccessNotification.NotificationName, 
                                        id:Guid.NewGuid().ToString(),
                                        title:"Awesome!",
                                        text:@this.Message);   
            }

            if(@this.IsFailure)
            {
                return new Notification(applicationName:"Growl Unit", 
                                        notificationName:FailureNotification.NotificationName, 
                                        id:Guid.NewGuid().ToString(),
                                        title:"Fail fail fail!",
                                        text:@this.Message);    
            }

            return new Notification(applicationName:"Growl Unit", 
                                    notificationName:FailureNotification.NotificationName, 
                                    id:Guid.NewGuid().ToString(),
                                    title:"Who knows!",
                                    text:"Go figure this out fool!");
        }
    }
}
