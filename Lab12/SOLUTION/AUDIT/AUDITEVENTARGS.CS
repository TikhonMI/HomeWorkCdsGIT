using System;

namespace Banking
{
	public class AuditEventArgs : System.EventArgs
	{	
		private readonly BankTransaction transData = null;

		public AuditEventArgs(BankTransaction transaction)
		{
			this.transData = transaction;
		}

		public BankTransaction getTransaction()
		{
			return this.transData;
		}

	}
}
