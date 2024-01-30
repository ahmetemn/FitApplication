using Di_Station.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Abstract
{
	public abstract class BaseDiet
	{
        public int ID { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; } = null;  

		public Status Status { get; set; } = Status.Added;

    }
}
