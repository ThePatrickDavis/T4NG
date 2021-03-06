using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TransactionHistoryArchiveEntity
    {
	public int TransactionID{ get; set; }
		public int ProductID{ get; set; }
		public int ReferenceOrderID{ get; set; }
		public int ReferenceOrderLineID{ get; set; }
		public DateTime TransactionDate{ get; set; }
		public string TransactionType{ get; set; }
		public int Quantity{ get; set; }
		public Decimal ActualCost{ get; set; }
		public DateTime ModifiedDate{ get; set; }
	}
}

