namespace GrowlUnit
{
    public interface IGrowler
    {
        void Notify(string title, string text);
        void Notify(GrowlMessage message);
    }
}