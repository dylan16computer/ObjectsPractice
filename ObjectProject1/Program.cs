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
            BankCustomers customer2 = new BankCustomers(54321, 22222, "Kevin", "James");
            BankCustomers customer3 = new BankCustomers(32561, 33333, "Adam", "Sandler");
            BankCustomers customer4 = new BankCustomers(58412, 44444, "Chris", "Rock");
            BankCustomers customer5 = new BankCustomers(95632, 55555, "James", "Heart");
            BankCustomers customer6 = new BankCustomers(46521, 66666, "Jake", "Bradley");

            List<BankCustomers> List1 = new List<BankCustomers>
            {
                customer1, customer2, customer3, customer4, customer5, customer6
            };
            foreach(var customer in List1)
            {
                Console.WriteLine($"First Name: {customer.FirstName}\nLast Name: {customer.LastName}\nAccount Number: {customer.AccountNumber}\nPIN: {customer.Pin}\n");
            }
        }
    }
}
