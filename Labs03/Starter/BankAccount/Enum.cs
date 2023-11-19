using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum AccountType { Checking, Deposit } //добавили перечисление 
    internal class Enum
    {
        static void Main(string[] args)
        {
            //добавили переменные типа AccountType и присвоили значения Checking и Deposit
            AccountType goldAccount = AccountType.Checking; 
            AccountType platinumAccount = AccountType.Deposit;
            //выводим значения в консоль
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
