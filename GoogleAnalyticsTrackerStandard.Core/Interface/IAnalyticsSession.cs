namespace GoogleAnalyticsTrackerStandard.Core.Interface
{
	public interface IAnalyticsSession
	{
		string GenerateSessionId();
		string GenerateCacheBuster();
	}
}