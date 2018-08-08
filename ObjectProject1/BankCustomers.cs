using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProject1
{
    public class BankCustomers
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
            get => pin; set => accountNumber = value;
        }
        public string FirstName
        {
            get => firstName; set => firstName = value;
        }
        public string LastName
        {
            get => lastName; set => firstName = value;
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
