using Growl.Connector;

namespace GrowlUnit.NotificationTypes
{
    public class SuccessNotification : NotificationType
    {
        public const string NotificationName = "Success";

        public SuccessNotification() : base(NotificationName,NotificationName)
        {
            Icon = Resources.Icons.pass;
        }
    }
}
