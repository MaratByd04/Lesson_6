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
    // класс для упражнения 7.1
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

    class BankAccount2
    {
        private static int nextAccountNumber = 1;

        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount2(decimal initialBalance)
        {
            AccountNumber = nextAccountNumber++;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Неверная сумма депозита.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
                Balance -= amount;
            else
                Console.WriteLine("Неверная сумма вывода или недостаточно средств.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            BankAccount account1 = new BankAccount("742672484", 450000, TypeOfBankAcc.Deposit);
            account1.Displayinformation();
            account1.SetBalance(30000);
            account1.Displayinformation();
            
        }
    }  
}
