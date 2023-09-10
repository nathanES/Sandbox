using System.Threading.Channels;
using Sandbox;
using Sandbox.RealTimeWeather;
using Sandbox.RetrieveTimeLine;
using Sandbox.WeatherForecast;

WeatherApi t = new WeatherApi();
string location = "40.75872069597532,-73.98529171943665";
string units = "metric"; // valeurs possible metric ou imperial
List<string> timeSteps = new List<string>() { "1d" }; // valeurs possible 1d, 1h

WeatherForecastApiInput weatherForecastApiInput = new WeatherForecastApiInput()
    { Location = location, TimeSteps = timeSteps, Units = units };
string p = t.WeatherForecastApi(weatherForecastApiInput).Result;
Console.WriteLine(p);

RealTimeWeatherApiInput realTimeWeatherApiInput = new RealTimeWeatherApiInput(){Location = location, Units = units};
string o = t.RealTimeWeatherApi(realTimeWeatherApiInput).Result;
Console.WriteLine(o);

RetrieveTimeLineApiInput retrieveTimeLineApiInput = new RetrieveTimeLineApiInput();
string m = t.RetrieveTimeLineApi(retrieveTimeLineApiInput).Result;
Console.WriteLine(m);




