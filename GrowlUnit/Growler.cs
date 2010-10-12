using System;
using Growl.Connector;

namespace GrowlUnit
{
    public class Growler : IGrowler
    {
        private readonly Application _application;        
        private readonly GrowlConnector _growl;
        private readonly NotificationType[] _notificationTypes;

        public Growler( string              applicationName, 
                        NotificationType[]  notificationTypes)
        {
            _notificationTypes = notificationTypes;
            _application = new Application(applicationName);
            _growl = new GrowlConnector
                         {
                             EncryptionAlgorithm = Cryptography.SymmetricAlgorithmType.PlainText                                                          
                         };            
            _growl.Register(_application, _notificationTypes);                 
        }
        
        public void Notify(Notification notification)
        {        
            _growl.Notify(notification);
        }

     
    }
}
