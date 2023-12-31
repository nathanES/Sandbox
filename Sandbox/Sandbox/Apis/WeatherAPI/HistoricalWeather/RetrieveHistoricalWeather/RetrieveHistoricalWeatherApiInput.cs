namespace Sandbox.Apis.HistoricalWeather.RetrieveHistoricalWeather;

public class RetrieveHistoricalWeatherApiInput
{
    public string Location { get; set; }
    public List<string> Fields { get; set; }
    public List<string> TimeSteps { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string Units { get; set; }
    public string TimeZone { get; set; }
}