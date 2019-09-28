using System;

namespace blazor_dynamic_themes_sample.Models
{
    internal class Weather
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string News { get; set; }
    }
}
