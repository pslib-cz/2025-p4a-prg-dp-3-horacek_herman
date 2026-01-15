using ILoggerDemo;
using ThirdParty;
using Adapters;

namespace LoggerAdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var thirdPartyAnalytics = new ThirdPartyAnalytics();

           
            ILogger logger = new AnalyticsLoggerAdapter(thirdPartyAnalytics);

            
            logger.Log("This is a normal message");
            logger.Log("WARNING: Something might be wrong");
            logger.Log("ERROR: Something went wrong");

            System.Console.WriteLine("Logging finished.");
        }
    }
}
