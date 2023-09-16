namespace Sandbox.WeatherForecastAndRealtime.RetrieveTimeLine;

public class RetrieveTimeLineApiInput
{
    public string Location { get; set; }
    public List<string> Fields { get; set; }
    public string Units { get; set; }
    public List<string> TimeSteps { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string TimeZone { get; set; }
    private void IsValidInput()
    {
        //Todo faire le contrôle des champs (required)
    }
}