using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
    public  class YemekCesidiUrun :BaseDiet
    {
        public int  YemekCesiId { get; set; }

        public TypeOfFood TypeOfFood { get; set; }
        public int ProductId {  get; set; } 
        public Product Product { get; set; }
    
        

    }
}
