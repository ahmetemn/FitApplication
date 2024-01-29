using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
    public class YemekKategori:BaseDiet
    {
        public int KategoriId { get; set; }

        public Category Category { get; set; }  

        public int YemekCesidi_Id { get; set; } 

        public TypeOfFood TypeOfFood { get; set; }  
    }
}
