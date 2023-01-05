namespace LearningProject
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int Pressure { get; set; }

        public int Humidity { get; set; }

        public string? Summary { get; set; }

      
    }
}