namespace Sandbox.Apis.WeatherForecastAndRealtime.RealTimeWeather;

public class RealTimeWeatherApiInput
{
    public string Location { get; set; }
    public string Units { get; set; }

    private void IsValidInput()
    {
        //Todo faire le contrôle des champs (required)
    }
}