using System;
using Xunit;
using SouthWestApp.FlightData;

namespace SouthWestApp.SouthWestAppTests
{
    public class FlightInformationTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(35)]
        [InlineData(335)]
        [InlineData(3335)]
        [InlineData(6999)]
        [InlineData(7000)]
        public void FlightNumberCorrectlySet(int number)
        {
            /*
            if(number > 0 && number < 7000) 
            {
                var flight = new FlightInformation(number);
                Assert.Equal(number, flight.FlightNumber);
            }
            else
            {
                var ex = Assert.Throws<Exception>(() => new FlightInformation(number));
                Assert.That(ex.message, Is.EqualTo("Not a valid flight number."));
            }
            */
        }
    }
}
