using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCustomers customer1 = new BankCustomers(12345, 1111, "John", "Smith");
            List<BankCustomers> List1 = new List<BankCustomers>
            {
                customer1
            };
            foreach(var customer in List1)
            {
                Console.WriteLine($"First Name: {customer.FirstName}\nLast Name: {customer.LastName}\nAccount Number: {customer.AccountNumber}\nPIN: {customer.Pin}");
            }
        }
    }
}
