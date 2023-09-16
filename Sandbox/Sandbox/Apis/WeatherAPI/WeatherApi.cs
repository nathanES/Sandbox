using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Sandbox.Apis.HistoricalWeather.RetrieveClimateNormals;
using Sandbox.Apis.HistoricalWeather.RetrieveHistoricalWeather;
using Sandbox.Apis.HistoricalWeather.WeatherRecentHistory;
using Sandbox.Apis.WeatherForecastAndRealtime.RealTimeWeather;
using Sandbox.Apis.WeatherForecastAndRealtime.RetrieveARoute;
using Sandbox.Apis.WeatherForecastAndRealtime.RetrieveTimeLine;
using Sandbox.Apis.WeatherForecastAndRealtime.WeatherForecast;
using Sandbox.Apis.WeatherMaps;

namespace Sandbox.Apis;

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
        string url = $"/v4/timelines?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Headers.Add("accept", "application/json");
        request.Content = new StringContent(JsonConvert.SerializeObject(retrieveTimeLineApiInput));
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> RetrieveARouteApi(RetrieveARouteApiInput retrieveARouteApiInput)
    {
        //TODO a tester
        string url = $"/v4/route?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Headers.Add("accept", "application/json");
        request.Content = new StringContent(JsonConvert.SerializeObject(retrieveARouteApiInput));
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> WeatherMapsApi(WeatherMapsApiInput weatherMapsApiInput)
    {
        //TODO a tester
        string url = $"/v4/map/tile/{weatherMapsApiInput.Zoom}/" +
                     $"{weatherMapsApiInput.X}/{weatherMapsApiInput.Y}/" +
                     $"{weatherMapsApiInput.Field}/" +
                     $"{weatherMapsApiInput.Time}.{weatherMapsApiInput.Format}" +
                     $"?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> WeatherRecentHistoryApi(WeatherRecentHistoryApiInput weatherRecentHistoryApiInput)
    {
        //TODO a tester
        string url = $"v4/weather/history/recent?apikey={ApiKeys.WeatherApiKey}";
        
        if (!String.IsNullOrWhiteSpace(weatherRecentHistoryApiInput.Location))
            url += "&location=" + weatherRecentHistoryApiInput.Location;
        if (!String.IsNullOrWhiteSpace(weatherRecentHistoryApiInput.Units))
            url += "&units=" + weatherRecentHistoryApiInput.Units;
        foreach (string timeStep in weatherRecentHistoryApiInput.TimeSteps)
        {
            url += "&timesteps=" + timeStep;
        }
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("accept", "application/json");
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> RetrieveHistoricalWeatherApi(RetrieveHistoricalWeatherApiInput retrieveHistoricalWeatherApiInput)
    {
        //TODO a tester
        string url = $"v4/historical?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Headers.Add("accept", "application/json");
        request.Content = new StringContent(JsonConvert.SerializeObject(retrieveHistoricalWeatherApiInput));
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
    public async Task<string> RetrieveClimateNormalsApi(RetrieveClimateNormalsApiInput retrieveClimateNormalsApiInput)
    {
        //TODO a tester
        string url = $"v4/historical/normals?apikey={ApiKeys.WeatherApiKey}";
        
        HttpClientSingleton clientSingleton = HttpClientSingleton.GetInstance();
        using var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Headers.Add("accept", "application/json");
        request.Content = new StringContent(JsonConvert.SerializeObject(retrieveClimateNormalsApiInput));
        var response = await clientSingleton.client.SendAsync(request);
        return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }
}