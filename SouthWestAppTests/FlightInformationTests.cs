using System;
using Xunit;
//using SouthWestApp.FlightData;

namespace SouthWestAppTests
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
            //var flight = new 
        }
    }
}
