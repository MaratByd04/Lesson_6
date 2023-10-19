using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.Tumakow
{
    enum TypeOfBankAcc
    {
        Deposit,
        Savings
    }

    class BankAccount
    {
        private string numberOfBankAccount;
        private decimal balance;
        private TypeOfBankAcc typeOfBankAcc;

        public BankAccount(string numberOfBankAccount, decimal balance, TypeOfBankAcc typeOfBankAcc)
        {
            this.numberOfBankAccount = numberOfBankAccount;
            this.balance = balance;
            this.typeOfBankAcc = typeOfBankAcc;
        }

        public string GetBankAccountNumber()
        {
            return numberOfBankAccount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public TypeOfBankAcc GetTypeOfBankAcc()
        {
            return typeOfBankAcc;
        }

        public void SetBalance(decimal newBalance)
        {
            balance = newBalance;
        }

        public void Displayinformation()
        {
            Console.WriteLine($"Номер счета: {numberOfBankAccount}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {typeOfBankAcc}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount счет = new BankAccount("742672484", 450000, TypeOfBankAcc.Deposit);
            счет.Displayinformation();
            счет.SetBalance(30000);
            счет.Displayinformation();
        }
    }
}
