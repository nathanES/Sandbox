namespace Sandbox.HistoricalWeather.RetrieveClimateNormals;

public class RetrieveClimateNormalsApiInput
{
    public string Location { get; set; }
    public List<string> Fields { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Units { get; set; }
}