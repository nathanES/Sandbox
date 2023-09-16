namespace Sandbox.Apis.WeatherForecastAndRealtime.WeatherForecast;

public class WeatherForecastApiInput
{
    public string Location { get; set; }
    public string Units { get; set; }
    public List<string> TimeSteps { get; set; }
    private void IsValidInput()
    {
        //Todo faire le contrôle des champs (required)
    }
}