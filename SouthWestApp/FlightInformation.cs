using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthWestApp.FlightData
{
    public class FlightInformation
    {
        /// <summary>
        /// This is the private backing variable for the flight number.
        /// </summary>
        private int _flightNumber;

        /// <summary>
        /// This is the flight number.
        /// </summary>
        public int FlightNumber
        {
            get => _flightNumber;
            set
            {
                if (value > 0 && value < 7000) _flightNumber = value;
                else throw new Exception("Not a valid flight number.");
            }
        }

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
