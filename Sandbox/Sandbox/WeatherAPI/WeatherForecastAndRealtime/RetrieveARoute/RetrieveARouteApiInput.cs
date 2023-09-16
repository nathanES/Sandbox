namespace Sandbox.WeatherForecastAndRealtime.RetrieveARoute;

public class RetrieveARouteApiInput
{
    public string Legs { get; set; }
    public List<string> Fields { get; set; }
    public string StartTime { get; set; }
    public string TimeStep { get; set; }
    public string Units { get; set; }
    public string TimeZone { get; set; }
    
    private void IsValidInput()
    {
        //Todo faire le contrôle des champs (required)
    }
    // Legs Example : (données récupéré de l'api de google maps)
    // [{
    //     "duration": 54,
    //     "location": {
    //         "type": "LineString",
    //         "coordinates": [
    //         [-6.80897, 62.00008],
    //         [-6.8047, 62.00069],
    //         [-6.7996, 62.00181],
    //         [-6.80149, 62.00293],
    //         [-6.80207, 62.00349],
    //         [-6.80226, 62.00375],
    //         [-6.80237, 62.00414]
    //             ]
    //     }
    // },
    // {
    //     "location": {
    //         "type": "LineString",
    //         "coordinates": [
    //         [100.0, 0.0],
    //         [101.0, 0.0],
    //         [101.0, 1.0],
    //         [100.0, 1.0],
    //         [100.0, 0.0]
    //             ]
    //     },
    //     "duration": 8
    // }
    // ]
}