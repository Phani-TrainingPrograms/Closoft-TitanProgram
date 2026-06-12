using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    abstract class BankAccount
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; private set; }//Balance can be set only within the BankAccount. 

        public void Credit(double amount)
        {
            Balance += amount;
        }

        public void Debit(double amount)
        {
            if(amount > Balance)
            {
                throw new Exception("Insufficient Funds");
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();
        
    }

    class SBAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            var interest = (this.Balance * 0.25 * 4.5) / 100;
            Credit(interest);
        }
    }

    class RDAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            throw new NotImplementedException("Do it URSELF");
        }
    }

    class FDAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }

    enum AccountType {  SBAccount, RDAccount, FDAccount };
    class AccountActivator
    {
        public static BankAccount CreateAccount(AccountType accountType)
        {
            BankAccount acc = null;//the object is not created yet.
            switch(accountType)
            {
                case AccountType.SBAccount:
                    acc = new SBAccount();
                    break;
                case AccountType.RDAccount:
                    acc = new RDAccount();
                    break;
                case AccountType.FDAccount:
                    acc = new FDAccount();
                    break;
                default:
                    throw new Exception("Invalid Account Type");               
            }
            return acc;
        }
    }
    internal class Ex18PracticalAbsClassExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Account type from the list below");
            //All Enums are of the type System.Enum
            var enumValues = Enum.GetValues(typeof(AccountType));
            foreach(var value in enumValues)
                Console.WriteLine(value);
            var accType = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);
            var account = AccountActivator.CreateAccount(accType);
            account.AccountNo = 123;
            account.AccountName = "Phani raj";
            account.Credit(50000);
            account.CalculateInterest();
            Console.WriteLine("The current balance is " + account.Balance);
        }
    }
}
