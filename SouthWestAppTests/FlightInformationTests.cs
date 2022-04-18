using System;
using Xunit;
using SouthWestApp.FlightData;

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
            if(number > 0 && number < 7000)
            {
                var flight = new FlightInformation(number);
                Assert.Equal(number, flight.FlightNumber);
            }
            else
            {
                Assert.Throws<Exception>(() => new FlightInformation(number));
            }
        }

        [Theory]
        [InlineData("John", "Smith", "90eh90")] // false
        [InlineData("John", "Smith", "90E%^*")] // false
        [InlineData("John", "Sm**h", "90EH90")] // false
        [InlineData("John", "Smith", "90EH9000")] // false
        [InlineData("John", "Smith", "90EH9")] // false
        [InlineData("Joh**n", "Smith", "90EH90")] // false
        public void CheckInfoCorrectlyThrowsException(string first, string last, string confirm)
        {
            var check = new CheckIn_Information();
            Assert.Throws<Exception>(() =>
            {
                check.FirstName = first;
                check.LastName = last;
                check.ConfirmationNumber = confirm;
            });
        }

        [Theory]
        [InlineData("John", "Smith", "909090")] // true
        [InlineData("John", "Smith", "90EH90")] // true
        [InlineData("Jo'hn", "Smith", "90EH90")] // true
        [InlineData("Jo-hn", "Smith", "90EH90")] // true
        [InlineData("John", "Sm-ith", "90EH90")] // true
        [InlineData("John", "Sm'ith", "90EH90")] // true
        public void CheckInfoCorrectlySets(string first, string last, string confirm)
        {
            var check = new CheckIn_Information();
            check.FirstName = first;
            check.LastName = last;
            check.ConfirmationNumber = confirm;
            Assert.Equal(first, check.FirstName);
            Assert.Equal(last, check.LastName);
            Assert.Equal(confirm, check.ConfirmationNumber);
        }
    }
}
