namespace Sandbox.HistoricalWeather.WeatherRecentHistory;

public class WeatherRecentHistoryApiInput
{
    public string Location { get; set; }
    public List<string> TimeSteps { get; set; }
    public string Units { get; set; }
}