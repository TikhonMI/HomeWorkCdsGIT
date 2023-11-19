using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    //создали перечисления с типами Checking, Deposit
    public enum AccountType { Checking, Deposit }
    //создали структуру BankAccount
    public struct BankAccount
    {
        //public - модификатор доступа, decimal - тип, accBal - имя переменной
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            //объявили переменную goldAccount типа BankAccount
            BankAccount goldAccount;

            //запрос ввода номера счета, присвоение значения полю accNo
            Console.WriteLine("Enter account nuumber: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            //переменной goldAccount присвоили значения полям accBal, accType
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accType = AccountType.Checking;
            
            //вывод элементов в консоль
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
        }
    }
}
