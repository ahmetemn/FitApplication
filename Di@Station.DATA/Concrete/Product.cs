using Di_Station.DATA.Abstract;
using Di_Station.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class Product :BaseDiet
	{
        public string ProductName { get; set; }
		public decimal Calorie { get; set; }
        public decimal Price { get; set; }
        public ICollection<YemekCesidiUrun> YemekCesidiUruns { get; set; }
    }
}


//public Category Category { get; set; }
//public ICollection<TypeOfFood> Foods { get; set; }
