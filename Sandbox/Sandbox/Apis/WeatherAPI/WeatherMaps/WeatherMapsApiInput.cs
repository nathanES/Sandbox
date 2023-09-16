namespace Sandbox.Apis.WeatherMaps;

public class WeatherMapsApiInput
{
    public string Zoom { get; set; }
    public string X { get; set; }
    public string Y { get; set; }
    public string Field { get; set; }
    public string Time { get; set; }
    public string Format { get; set; }
    
    private void IsValidInput()
    {
        //Todo faire le contrôle des champs (required)
    }
    
    //Zoom : Zoom level for the map, 1-12
    //X : The X coordinate on the map
    //Y : The Y coordinate on the map
    //Field : Select fields for data layers, precipitationIntensity
    //Time : Time in ISO 8601 format
    //Format : Format of the return tiles, png
}