using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class AirlineFlight
    {
        [JsonProperty("hex")]
        public string? Hex { get; set; }

        [JsonProperty("reg_number")]
        public string? RegNumber { get; set; }

        [JsonProperty("flag")]
        public string? Flag { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("alt")]
        public int Alt { get; set; }

        [JsonProperty("dir")]
        public int Dir { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }

        [JsonProperty("v_speed")]
        public double VSpeed { get; set; }

        [JsonProperty("squawk")]
        public string? Squawk { get; set; }

        [JsonProperty("flight_number")]
        public string? FlightNumber { get; set; }

        [JsonProperty("flight_icao")]
        public string? FlightIcao { get; set; }

        [JsonProperty("flight_iata")]
        public string? FlightIata { get; set; }

        [JsonProperty("dep_icao")]
        public string? DepIcao { get; set; }

        [JsonProperty("dep_iata")]
        public string? DepIata { get; set; }

        [JsonProperty("arr_icao")]
        public string? ArrIcao { get; set; }

        [JsonProperty("arr_iata")]
        public string? ArrIata { get; set; }

        [JsonProperty("airline_icao")]
        public string? AirlineIcao { get; set; }

        [JsonProperty("airline_iata")]
        public string? AirlineIata { get; set; }

        [JsonProperty("aircraft_icao")]
        public string? AircraftIcao { get; set; }

        [JsonProperty("updated")]
        public long Updated { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}
