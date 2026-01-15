using ILoggerDemo;
using ThirdParty;

namespace Adapters
{
    
    public class AnalyticsLoggerAdapter : ILogger
    {
        private readonly ThirdPartyAnalytics _analytics;

        public AnalyticsLoggerAdapter(ThirdPartyAnalytics analytics)
        {
            _analytics = analytics;
        }

        public void Log(string message)
        {
           
            int severity = 1; 
            if (message.Contains("ERROR")) severity = 3;
            else if (message.Contains("WARNING")) severity = 2;

            
            _analytics.TrackEvent(message, severity);
        }
    }
}
