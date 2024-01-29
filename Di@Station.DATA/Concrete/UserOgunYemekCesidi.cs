using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
    public  class UserOgunYemekCesidi:BaseDiet
    {

        public int UserId { get; set; }

        public User User { get; set; }


        public int YemekCesidiPorsiyonOgun_Id  { get; set; }

        public YemekCesidiPorsiyonOgun  YemekCesidiPorsiyonOgun { get; set; }   
    }
}
