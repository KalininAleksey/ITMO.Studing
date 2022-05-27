using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Studing.CScourse.Lab6.Ex2.UniqueNumbers
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
    }
}
