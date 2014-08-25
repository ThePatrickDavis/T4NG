using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WorkOrderRoutingEntity
    {
	public int WorkOrderID{ get; set; }
		public int ProductID{ get; set; }
		public System.SByte OperationSequence{ get; set; }
		public System.SByte LocationID{ get; set; }
		public DateTime ScheduledStartDate{ get; set; }
		public DateTime ScheduledEndDate{ get; set; }
		public DateTime? ActualStartDate{ get; set; }
		public DateTime? ActualEndDate{ get; set; }
		public Decimal? ActualResourceHrs{ get; set; }
		public Decimal PlannedCost{ get; set; }
		public Decimal? ActualCost{ get; set; }
		public DateTime ModifiedDate{ get; set; }
	}
}

