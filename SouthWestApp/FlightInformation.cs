using System;

namespace SouthWestApp
{
    class FlightInformation
    {
        /// <summary>
        /// This is the private backing variable for the flight number.
        /// </summary>
        private int _flightNumber;

        /// <summary>
        /// This is the flight number.
        /// </summary>
        public int FlightNumber { get { return _flightNumber; } set { _flightNumber = value; } }

        /// <summary>
        /// This is the constructor for the flight information.
        /// </summary>
        /// <param name="flight_num">This is the flight info.</param>
        public FlightInformation(int flight_num)
        {
            FlightNumber = flight_num;
        }
    }
}
