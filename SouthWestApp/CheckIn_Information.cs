using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightData
{
    public class CheckIn_Information
    {
        /// <summary>
        /// This is a private backing variable for the first name.
        /// </summary>
        private string _firstname;

        /// <summary>
        /// This is the first name of the person checking in.
        /// </summary>
        public string FirstName
        {
            get => _firstname;
            set
            {
                foreach(char c in value)
                {
                    if(!(((int)c > 64 && (int)c < 90) || ((int)c > 96 && (int)c < 123) || (int)c == 32 || (int)c == 44 || (int)c == 45))
                    {
                        throw new Exception("No numbers or special characters allowed in the name.");
                    }
                }
                _firstname = value;
            }
        }

        /// <summary>
        /// This is a private backing variable for the last name.
        /// </summary>
        private string _lastname;

        /// <summary>
        /// This is the last name of the person checking in.
        /// </summary>
        public string LastName
        {
            get => _lastname;
            set
            {
                foreach (char c in value)
                {
                    if (!(((int)c > 64 && (int)c < 90) || ((int)c > 96 && (int)c < 123) || (int)c == 32 || (int)c == 44 || (int)c == 45))
                    {
                        throw new Exception("No numbers or special characters allowed in the name.");
                    }
                }
                _lastname = value;
            }
        }

        /// <summary>
        /// This is a private backing variable for the confirmation number.
        /// </summary>
        private int _confirmationNumber;

        /// <summary>
        /// This is the confirmation number.
        /// </summary>
        public int ConfirmationNumber
        {
            get => _confirmationNumber;
            set
            {
                string temp = Convert.ToString(value);
                foreach(char c in temp)
                {
                    if(!((int)c > 47 && (int)c < 58))
                    {
                        throw new Exception("Only numbers allowed in the confirmation number");
                    }
                }
                _confirmationNumber = value;
            }
        }
    }
}
