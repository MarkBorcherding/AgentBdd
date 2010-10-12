using Growl.Connector;
using Growl.CoreLibrary;

namespace GrowlUnit
{
    public interface IGrowler
    {        
        void Notify(Notification notification);
    }
}