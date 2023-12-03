namespace EventTestHarness
{
using System;
using Banking;

/// <summary>
///    Test harness for the Auditing event handler
/// </summary>
public class Test
{
	public static void Main()
	{
		// Create two bank accounts
		long accNo1 = Bank.CreateAccount(200);
		long accNo2 = Bank.CreateAccount(100);

		BankAccount acc1 = Bank.GetAccount(accNo1);
		BankAccount acc2 = Bank.GetAccount(accNo2);

		// Create audit trails for each account
		acc1.AuditTrail("Account1.dat");
		acc2.AuditTrail("Account2.dat");

		// Do some work
		acc1.Deposit(100);
		acc1.Withdraw(50);
		acc1.Withdraw(100);
		acc1.Deposit(25);

		acc2.Withdraw(75);
		acc2.Deposit(100);
		acc2.Withdraw(35);
		acc2.Deposit(10);
		acc2.Deposit(50);

		// Close both accounts
		Bank.CloseAccount(accNo1);
		Bank.CloseAccount(accNo2);
	}
}
}
