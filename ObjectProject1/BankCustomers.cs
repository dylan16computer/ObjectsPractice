using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProject1
{
    class BankCustomers
    {
        float accountNumber;
        float pin;
        string firstName;
        string lastName;

        public float AccountNumber
        {
            get => accountNumber; set => accountNumber = value;
        }
        public float Pin
        {
            get => pin; set => pin = value;
        }
        public string FirstName
        {
            get => firstName; set => firstName = value;
        }
        public string LastName
        {
            get => lastName; set => lastName = value;
        }
        public BankCustomers(float _AccountNumber, float _Pin, string _FirstName, string _LastName)
        {
            AccountNumber = _AccountNumber;
            Pin = _Pin;
            FirstName = _FirstName;
            LastName = _LastName;
        }
    }
}
