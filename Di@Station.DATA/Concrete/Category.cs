using Di_Station.DATA.Abstract;
using Di_Station.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class Category :BaseDiet
	{
        public string CategoryName { get; set; }
		
		public ICollection<YemekKategori> YemekKategoris { get; set; }


    }
}


//public ICollection<TypeOfFood> Foods { get; set; }
//public ICollection<Product> Products { get; set; }