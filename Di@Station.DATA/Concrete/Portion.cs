using Di_Station.DATA.Abstract;
using Di_Station.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class Portion:BaseDiet
	{
		
		public decimal Scale { get; set; }
        public ICollection<YemekCesidiPorsiyonOgun> YemekCesidiPorsiyonOguns { get; set; }
    }
}


//public ICollection<TypeOfFood> Foods { get; set; }