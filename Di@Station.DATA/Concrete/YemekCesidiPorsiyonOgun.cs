using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
    public class YemekCesidiPorsiyonOgun:BaseDiet
    {



        public int YemekCesidi_ID { get; set; }
        public TypeOfFood TypeOfFood { get; set; }
        public int Porsiyon_Id { get; set; }
        public Portion Portion { get; set; }

        public int OgunId { get; set; }
        public Meal Meal { get; set; }  
    }
}
