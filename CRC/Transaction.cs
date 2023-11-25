using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Code_21.CRC
{
    public class Transaction
    {
        // Responsibilities:
        // 1. Record details of a financial transaction
        // 2. Possibly update the balances of involved BankAccounts

        // Collaborators:
        // - BankAccount (for updating balances)

        public void RecordTransaction(BankAccount source, BankAccount destination, decimal amount)
        {

            Console.WriteLine($"Transaction recorded: ${amount} transferred from {source} to {destination}");
        }
    }
}
