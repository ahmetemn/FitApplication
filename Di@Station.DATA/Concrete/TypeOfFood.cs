using Di_Station.DATA.Abstract;
using Di_Station.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class TypeOfFood :BaseDiet
	{

        public string MenuName { get; set; }
        public decimal Kalori { get; set; }
        public  decimal Fiyat { get; set; }
        public ICollection<YemekCesidiPorsiyonOgun> YemekCesidiPorsiyonOguns { get; set; }
        public ICollection<YemekCesidiUrun> yemekCesidiUruns{ get; set; }

        //FLUENT APİDE UNİQUE YAPMAYI UNUTMA 
        public ICollection<YemekKategori> YemekKategoris { get; set;  }
    }
}




//public int ProductId { get; set; }
//public ICollection<Product> Products { get; set; }
//public int PortionId { get; set; }
//public ICollection<Portion> Portions { get; set; }
//public int CategoryId { get; set; }
//public Category Category { get; set; }
//public int MealId { get; set; }
//public ICollection<Meal> Meals { get; set; }
