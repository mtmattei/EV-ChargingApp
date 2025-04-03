namespace ChargingPort.Helpers
{
    public static class StringFormatHelper
    {
        public static string FormatEstimatedTime(string timeRemaining)
        {
            return $"Est. {timeRemaining} until full";
        }
    }
}
