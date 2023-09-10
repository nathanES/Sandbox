namespace Sandbox.WeatherForecast;

public class WeatherForecastApiInput
{
    public string Location { get; set; }
    public string Units { get; set; }
    public List<string> TimeSteps { get; set; }
}