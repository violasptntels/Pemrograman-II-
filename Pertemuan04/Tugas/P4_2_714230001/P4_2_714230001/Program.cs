using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BudgetManager manager = new BudgetManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. View Transaction History");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter income amount: ");
                        double income = Convert.ToDouble(Console.ReadLine());
                        manager.AddTransaction("income", income);
                        Console.WriteLine("Pemasukan berhasil ditambahkan.");
                        break;
                    case "2":
                        Console.Write("Enter expense amount: ");
                        double expense = Convert.ToDouble(Console.ReadLine());
                        manager.AddTransaction("expense", expense);
                        Console.WriteLine("Pengeluaran berhasil ditambahkan.");
                        break;
                    case "3":
                        Console.WriteLine($"Current balance: ${manager.GetBalance()}");
                        break;
                    case "4":
                        manager.ShowTransactions();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
