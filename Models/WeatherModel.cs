namespace WeatherApp.Models
{

    public class WeatherModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float elevation { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public Current_Weather current_weather { get; set; }
        public Hourly hourly { get; set; }
        public Hourly_Units hourly_units { get; set; }
        public Daily daily { get; set; }
        public Daily_Units daily_units { get; set; }
    }

    public class Current_Weather
    {
        public float temperature { get; set; }
        public float windspeed { get; set; }
        public float winddirection { get; set; }
        public float weathercode { get; set; }
        public string time { get; set; }
    }

    public class Hourly
    {
        public float[] temperature_2m { get; set; }
        public string[] time { get; set; }
    }

    public class Hourly_Units
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Daily
    {
        public float[] weathercode { get; set; }
        public float[] apparent_temperature_max { get; set; }
        public string[] time { get; set; }
        public float[] apparent_temperature_min { get; set; }
    }

    public class Daily_Units
    {
        public string apparent_temperature_max { get; set; }
        public string weathercode { get; set; }
        public string time { get; set; }
        public string apparent_temperature_min { get; set; }
    }

}
