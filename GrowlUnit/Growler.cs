using System;
using Growl.Connector;

namespace GrowlUnit
{
    public class Growler : IGrowler
    {
        private readonly Application _application;
        private readonly NotificationType _notificationType;
        private readonly GrowlConnector _growl;

        public Growler(string applicationName)
        {
            _application = new Application(applicationName);
            _notificationType = new NotificationType("SAMPLE_NOTIFICATION", "Sample Notification");

            _growl = new GrowlConnector
                         {
                             EncryptionAlgorithm = Cryptography.SymmetricAlgorithmType.PlainText
                         };

            _growl.Register(_application, new[] { _notificationType });

        }

        public void Notify(string title, string text)
        {
            var notification = new Notification(_application.Name, 
                                                _notificationType.Name, 
                                                DateTime.Now.Ticks.ToString(), 
                                                title, 
                                                text);
            _growl.Notify(notification);
        }

        public void Notify(GrowlMessage message)
        {
            Notify(message.Title, message.Message);
        }
    }
}
