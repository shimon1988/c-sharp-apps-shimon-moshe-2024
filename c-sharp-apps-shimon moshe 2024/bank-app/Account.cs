using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.bank_app
{
    internal class Account
    {
        private const double MAX_OVERDRAFT = 90000;

        private Owner owner;
        private double balance;
        private int overdraft;

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.SetOverdraft(overdraft);
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > MAX_OVERDRAFT)
            {
                Console.WriteLine("Overdraft cannot exceed maximum overdraft limit.");
              
            }
            else
            {
                this.overdraft = overdraft;

            }


        }
        public Owner GetOwner()
        {

        return owner; }

        public double GetBalance()
        {

        return balance; }

        public int GetOverdraft()
        {
            return overdraft;
        }
        public void Withdraw(double amount)
        {
            if (balance-amount >= -overdraft)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds available balance and overdraft limit.");
            }
        }

       


        public void PrintAccountDetails()
        {
            owner.PrintOwnerDetails();
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Overdraft: {overdraft}");
        }
    }
}
