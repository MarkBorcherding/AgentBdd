using Growl.Connector;

namespace GrowlUnit.NotificationTypes
{
    public class FailureNotification : NotificationType
    {
        public const string NotificationName = "Failure";

        public FailureNotification() : base(NotificationName,NotificationName)
        {
            Icon = Resources.Icons.red_error;
        }
    }
}
