using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230001
{
    public class BudgetManager : MoneyManager
    {
        private double balance;
        private List<string> transactions;

        // Constructor
        public BudgetManager()
        {
            balance = 0.0;
            transactions = new List<string>();
        }

        // Implementasi metode abstrak
        public override void AddTransaction(string type, double amount)
        {
            if (type.ToLower() == "income")
            {
                balance += amount;
                transactions.Add($"Income: ${amount}");
            }
            else if (type.ToLower() == "expense")
            {
                balance -= amount;
                transactions.Add($"Expense: ${amount}");
            }
        }

        public override double GetBalance()
        {
            return balance;
        }

        // Metode tambahan untuk menampilkan riwayat transaksi
        public void ShowTransactions()
        {
            Console.WriteLine("Transaction History:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}