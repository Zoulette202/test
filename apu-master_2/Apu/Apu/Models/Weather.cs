using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apu.Models
{
    public class Weather
    {
        [JsonProperty(PropertyName = "name")]
        public string City { get; set; } = "";

        [JsonProperty(PropertyName = "main.temp")]
        public double Temperature { get; set; } = 0;

        [JsonProperty(PropertyName = "speed")]
        public double Wind { get; set; } = 0;

        [JsonProperty(PropertyName = "humidity")]
        public double Humidity { get; set; } = 0;

        [JsonProperty(PropertyName = "visibility")]
        public double Visibility { get; set; } = 0;

        public Sun Sun { get; set; } = new Sun();

        public string Icon { get; set; } = "";



    }

    public class Sun
    {
        [JsonProperty(PropertyName = "sunrise")]
        public DateTime Sunrise { get; set; } = DateTime.Now;

        [JsonProperty(PropertyName = "sunset")]
        public DateTime Sunset { get; set; } = DateTime.Now;
    }

}
