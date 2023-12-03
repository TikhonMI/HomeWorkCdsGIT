namespace AuditTestHarness
{
using System;
using Banking;

/// <summary>
///    Test Harness for the Audit Class.
/// </summary>
public class Test
{
	public static void Main()
	{
		Audit testAudit = new Audit("AuditTrail.dat");
		BankTransaction testTran = new BankTransaction(500);
		AuditEventArgs testArg = new AuditEventArgs(testTran);
		testAudit.RecordTransaction(null, testArg);

		BankTransaction testTran2 = new BankTransaction(-200);
		AuditEventArgs testArg2 = new AuditEventArgs(testTran2);
		testAudit.RecordTransaction(null, testArg2);

		testAudit.Close();
	}
}
}
