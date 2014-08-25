using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VendorEntity
    {
	public int BusinessEntityID{ get; set; }
		public object AccountNumber{ get; set; }
		public object Name{ get; set; }
		public Int16 CreditRating{ get; set; }
		public object PreferredVendorStatus{ get; set; }
		public object ActiveFlag{ get; set; }
		public string PurchasingWebServiceURL{ get; set; }
		public DateTime ModifiedDate{ get; set; }
	}
}

