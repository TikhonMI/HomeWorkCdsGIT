
using System;
using System.Collections;
using Banking;

// Test harness
class CreateAccount
{
    static void Main() 
    {

		// Create two bank accounts. Use Bank.CreateAccount(...) with the same balance and type
		// Store the numbers of these two accounts in long variables accNo1 and accNo2
		long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
		long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

		// Create two BankAccount variables, acc1 and acc2. 
		// Use Bank.GetAccount() to populate them with the two accounts just created
		BankAccount acc1 = Bank.GetAccount(accNo1);
		BankAccount acc2 = Bank.GetAccount(accNo2);

		// Compare acc1 and acc2 using Equals (should be false as the account numbers will be different)
			if (acc1.Equals(acc2)) {
			Console.WriteLine("Both accounts are the same. They should not be!");
		} else {
			Console.WriteLine("The accounts are different. Good!");
		}

		// Compare acc1 and acc2 using Equals (should be true as the account numbers will be different)
		if (!acc1.Equals(acc2)) {
			Console.WriteLine("The accounts are different. Good!");
		} else {
			Console.WriteLine("Both accounts are the same. They should not be!");
		}

		// Create a third BankAccount variable, acc3, and populate it with the account whose
		// account number is in accNo1. Use Bank.GetAccount()
		BankAccount acc3 = Bank.GetAccount(accNo1);
	
		// Compare acc1 and acc3 using the == operator (should be true as all the data will be the same)
		if (acc1 == acc3) {
			Console.WriteLine("The accounts are the same. Good!");
		} else {
			Console.WriteLine("The accounts are different. They should not be!");
		}
		// Compare acc1 and acc3 using the == operator (should be false)
		if (acc1 != acc3) {
			Console.WriteLine("The accounts are different. They should not be!");
		} else {
			Console.WriteLine("The accounts are the same. Good!");
		}
		Console.WriteLine("acc1 - {0}",acc1);
		Console.WriteLine("acc2 - {0}",acc2);
		Console.WriteLine("acc3 - {0}",acc3);
		
		acc1.Dispose();
		acc2.Dispose();

    }
    
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());

		// Print out the transactions (if any)
		Console.WriteLine("Transactions");
		Queue tranQueue = acc.Transactions();
		foreach (BankTransaction tran in tranQueue) {
			Console.WriteLine("Date: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
    }
}
