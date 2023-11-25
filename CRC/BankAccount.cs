using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Code_21.CRC
{
    public class BankAccount
    {
        // Responsibilities:
        // 1. Maintain account balance
        // 2. Allow deposits and withdrawals

        // Collaborators: None directly in this simple example
        // (In a more complex system, it might collaborate with a Transaction class, for example)

        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}
