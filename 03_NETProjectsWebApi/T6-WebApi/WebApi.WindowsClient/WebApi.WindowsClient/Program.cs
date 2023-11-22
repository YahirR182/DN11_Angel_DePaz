using System.Text;
using Api.Entities;
using WebApi.WindowsClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //GetIp();

        System.Threading.Thread.Sleep(5000);
       var forecast= GetZoneWeatherForecast(new Zone
        {
            City="Acapulco",
            Date=new DateTime(2023,11,22)
        }).Result;

        Console.WriteLine("Ciudad: "+forecast.Zone.City);
        Console.WriteLine("Fecha: " + forecast.Zone.Date);

        foreach(var item in forecast.WeatherForecast)
        {
            Console.WriteLine();
            Console.WriteLine("Summary: " + item.Summary);
            Console.WriteLine("TemperatureC: " + item.TemperatureC);
            Console.WriteLine("TemperatureF: " + item.TemperatureF);
        }
        Console.ReadKey();
    }

    private static async Task<ZoneWeatherForecast> GetZoneWeatherForecast(Zone zone)
    {
        
        string JsonContent= Newtonsoft.Json.JsonConvert.SerializeObject(zone);
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.PostAsync("https://localhost:7233/weatherforecast/byzone",new StringContent(JsonContent,Encoding.UTF8,"application/json"));
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        ZoneWeatherForecast forecast = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeatherForecast>(responseBody);


        //Console.WriteLine("My current IP address is: " + ip.Ip);

        //var info = await GetIpInfo(ip.Ip);

        //Console.WriteLine("Country: " + info.Country);
        //Console.WriteLine("City: " + info.City);
        //Console.WriteLine("Time Zone: " + info.TimeZone);
        return forecast;
    }


    private static async Task<IpAddress> GetIp()
    {
        HttpClient client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync("http://api.ipify.org/?format-json");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);


        Console.WriteLine("My current IP address is: " + ip.Ip);

        var info = await GetIpInfo(ip.Ip);
        
        Console.WriteLine("Country: " + info.Country);
        Console.WriteLine("City: " + info.City);
        Console.WriteLine("Time Zone: " + info.TimeZone);
        return ip;
    }

    private static async Task<IpInfo> GetIpInfo(string ipAddress)
    {
        HttpClient client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync($"http://ipinfo.io/{ipAddress}/geo");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);
        
        return info;
    }



}