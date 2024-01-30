using Di_Station.DATA.Concrete;
using Di_Station.REPO.ConcreteREPO;
using Di_Station.REPO.Intefaces;
using Di_Station.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.Service.Concrate
{
    public class UserSERVICE : BaseDietService<User>, IUserSERVICE
    {
        private IUserREPO _userREPO;


        private CategoryREPO _categoryREPO; 
        public UserSERVICE()
        {
                _userREPO = new UserREPO();
               
        }
      
        //operasyon 
        public List<User> getSurnameByUserId(int id)
        {
            
            if (id  > 0  )
            {
                return _userREPO.GetSurnameUser(id); 

            }
            else
            {
                throw new Exception("Hata"); 
            }
        }
    }
}
