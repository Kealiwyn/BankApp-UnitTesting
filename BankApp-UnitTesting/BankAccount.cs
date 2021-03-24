using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        private double balance;
        public double Balance { get { return balance; } }
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }

        public BankAccount (int accountNumber, string customerName, double balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be 0 nor negative");
            }
            else if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be greater than the Balance");
            }
            else
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be 0 nor negative");
            }
            else
            balance += amount;
        }

        public override string ToString()
        {
            return $"Account Number: #{AccountNumber} -- Customer name: {CustomerName} -- Your balance: {Balance:c}";
        }
    }
}
