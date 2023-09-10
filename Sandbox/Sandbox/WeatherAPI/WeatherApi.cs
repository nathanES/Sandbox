using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Sandbox.RealTimeWeather;
using Sandbox.RetrieveTimeLine;
using Sandbox.WeatherForecast;
namespace Sandbox;

public class WeatherApi
{
    
    public WeatherApi()
    {
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        clientSingleton.client.BaseAddress = new Uri("https://api.tomorrow.io");
        clientSingleton.client.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<string> WeatherForecastApi(WeatherForecastApiInput weatherForecastApiInput)
    {
        string url = $"/v4/weather/forecast?apikey={ApiKeys.WeatherApiKey}";
        if (!String.IsNullOrWhiteSpace(weatherForecastApiInput.Location))
            url += "&location=" + weatherForecastApiInput.Location;
        if (!String.IsNullOrWhiteSpace(weatherForecastApiInput.Units))
            url += "&units=" + weatherForecastApiInput.Units;
        foreach (string timeStep in weatherForecastApiInput.TimeSteps)
        {
            if (!String.IsNullOrWhiteSpace(timeStep))
                url += "&timesteps=" + timeStep;
        }
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> RealTimeWeatherApi(RealTimeWeatherApiInput realTimeWeatherApiInput)
    {
        string url = $"/v4/weather/realtime?apikey={ApiKeys.WeatherApiKey}";
        if (!String.IsNullOrWhiteSpace(realTimeWeatherApiInput.Location))
            url += "&location=" + realTimeWeatherApiInput.Location;
        if (!String.IsNullOrWhiteSpace(realTimeWeatherApiInput.Units))
            url += "&units=" + realTimeWeatherApiInput.Units;
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }

    public async Task<string> RetrieveTimeLineApi(RetrieveTimeLineApiInput retrieveTimeLineApiInput)
    {
        //TODO a continuer
        string url = $"/v4/weather/timelines?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }

}