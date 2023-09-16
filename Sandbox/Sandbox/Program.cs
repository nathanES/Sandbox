using System.Collections.Specialized;
using System.Threading.Channels;
using Sandbox;
using Sandbox.WeatherForecastAndRealtime.RetrieveTimeLine;

WeatherApi t = new WeatherApi();
string locationSelestat = "48.26022516227368, 7.454316818493369";
string locationStrasbourg = "48.57288317551469, 7.754187747850271";
string locationWacken2 = "48.59850803136551, 7.7656789069834025";
string units = "metric"; // valeurs possible metric ou imperial
List<string> timeSteps = new List<string>() { "1h" }; // valeurs possible 1d, 1h
string startTime = "now";
string endTime = "nowPlus6h";


// WeatherForecastApiInput weatherForecastApiInput = new WeatherForecastApiInput()
//     { Location = location, TimeSteps = timeSteps, Units = units };
// string p = t.WeatherForecastApi(weatherForecastApiInput).Result;
// Console.WriteLine(p);
//
// RealTimeWeatherApiInput realTimeWeatherApiInput = new RealTimeWeatherApiInput(){Location = location, Units = units};
// string o = t.RealTimeWeatherApi(realTimeWeatherApiInput).Result;
// Console.WriteLine(o);

List<string> fields = new List<string>() { "temperature" };

RetrieveTimeLineApiInput retrieveTimeLineApiInput = new RetrieveTimeLineApiInput()
{
    Location = locationSelestat, TimeSteps = timeSteps, Units = units, StartTime = startTime, EndTime = endTime,
    Fields = fields,TimeZone = "auto"
};
string m = t.RetrieveTimeLineApi(retrieveTimeLineApiInput).Result;
Console.WriteLine(m);




