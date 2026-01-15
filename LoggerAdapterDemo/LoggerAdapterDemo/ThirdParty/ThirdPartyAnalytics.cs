namespace ThirdParty
{
   
    public class ThirdPartyAnalytics
    {
        public void TrackEvent(string eventName, int severity)
        {
            System.Console.WriteLine($"[ThirdPartyAnalytics] Event: {eventName}, Severity: {severity}");
        }
    }
}
