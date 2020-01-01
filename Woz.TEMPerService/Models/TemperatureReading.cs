using System;
using Woz.Functional.Monads;
using static Woz.Functional.FreeFunctions;
using Woz.TEMPer;

namespace Woz.TEMPerService.Models
{
    public class TemperatureReading
    {
        private readonly SensorResult _sensorResult;

        public static TemperatureReading Create(SensorResult sensorResult)
            => new TemperatureReading(sensorResult);

        private TemperatureReading(SensorResult sensorResult)
        {
            _sensorResult = sensorResult;
        }

        public string MachineName => Environment.MachineName;
        public DateTime Date => DateTime.Now;
        public string SensorType => _sensorResult.SensorType.ToString();
        public string DeviceId => _sensorResult.DeviceId;
        public string Manufacturer => _sensorResult.Manufacturer;
        public decimal? Temperature => ReadTemperature(_sensorResult.Result);
        public string? Error => ReadError(_sensorResult.Result);

        private decimal? ReadTemperature(Result<decimal, string> temperatureResult)
            => temperatureResult.Match<decimal, decimal?, string>(v => v, e => null);

        private string? ReadError(Result<decimal, string> temperatureResult)
            => _sensorResult.Result.Match(v => null, Identity);
    }
}
