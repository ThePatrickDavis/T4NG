using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WorkOrderEntity
    {
	public int WorkOrderID{ get; set; }
		public int ProductID{ get; set; }
		public int OrderQty{ get; set; }
		public int StockedQty{ get; set; }
		public System.SByte ScrappedQty{ get; set; }
		public DateTime StartDate{ get; set; }
		public DateTime? EndDate{ get; set; }
		public DateTime DueDate{ get; set; }
		public System.SByte? ScrapReasonID{ get; set; }
		public DateTime ModifiedDate{ get; set; }
	}
}

