using System;
using SimpleProjAPI.Controllers;
using Xunit;

namespace SimpleProjAPI.Test
{
    public class WeatherForecastTest
    {
        WeatherForecastController _weatherForecastController = new WeatherForecastController();

        [Fact]
        public void Get_HotWeatherForecast()
        {
            //Arrange
            const string _hotWeather = "Hot";

            // Act
            var _weatherForecast = _weatherForecastController.Get(_hotWeather);

            // Assert
            Assert.True(_weatherForecast.Summary == _hotWeather);
        }
    }
}
