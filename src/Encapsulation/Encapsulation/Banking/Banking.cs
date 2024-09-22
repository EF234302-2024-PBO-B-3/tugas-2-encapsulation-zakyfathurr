using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber="Unknown";
        private string _accountHolder="Unknown";
        private double _balance;

        public string AccountNumber{
            get{return _accountNumber;}
            set{_accountNumber = value;}
        }
        public string AccountHolder{
            get{return _accountHolder;}
            set{_accountHolder = value;}
        }
        public double Balance{
            get{return _balance;}
            set{_balance = (value<=0)? 0: value;}
        }

        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            Balance = (initialBalance<=0)? 0: initialBalance;
            AccountHolder = (accountHolder == null || accountHolder =="")? "Unknown": accountHolder;
            AccountNumber = (accountNumber == null || accountNumber =="")? "Unknown": accountNumber;
            // Balance-initialBalance;
            // AccountHolder = accountHolder;
            // AccountNumber = accountNumber;

        }

        public void Deposit(double amount)
        {
            if(amount>0)
                Balance += amount;
            else{
                Console.WriteLine("amount need to more than 0");
            }
        }

        public void Withdraw(double amount)
        {
            if(amount>0 && amount<=Balance)
                Balance -= amount;
            else{
                Console.WriteLine("amount more than balance");
            }
        }

        public double GetBalance()
        {
            // Console.WriteLine($"Your Balance is {Balance}");
            return Balance;
        }
    }
}