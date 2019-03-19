using GoogleAnalyticsTrackerStandard.Core;
using GoogleAnalyticsTrackerStandard.Core.TrackerParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoogleAnalyticsTrackerStandard.Simple
{
    public static class ScreenviewTrackerExtension
    {
        public static async Task<TrackingResult> TrackScreenviewAsync(this SimpleTracker tracker, string appName,
            string appId, string appVersion, string appInstallerId, string screenName, IDictionary<int, string> customDimensions)
        {
            var screenviewParamenters = new ScreenviewTracking
            {
                ApplicationName = appName,
                ApplicationId = appId,
                ApplicationVersion = appVersion,
                ApplicationInstallerId = appInstallerId,
                ScreenName = screenName,
            };

            screenviewParamenters.SetCustomDimensions(customDimensions);

            return await tracker.TrackAsync(screenviewParamenters);
        }
    }
}
