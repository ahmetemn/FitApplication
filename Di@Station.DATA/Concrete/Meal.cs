using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class Meal :BaseDiet
	{
        public string Name { get; set; }
		
		public ICollection<YemekCesidiPorsiyonOgun> YemekCesidiPorsiyonOguns {  get; set; }	
	}
}
