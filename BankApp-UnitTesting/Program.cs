using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1414, "Richard", 300.00);

            Console.Write("Please type an amount to deposit: ");
            myAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(myAccount.ToString());


            Console.ReadKey();
        }
    }
}
