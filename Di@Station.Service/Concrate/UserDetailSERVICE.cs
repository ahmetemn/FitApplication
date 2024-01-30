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
    public class UserDetailSERVICE : BaseDietService<UserDetail>, IUserDetailSERVICE
    {

        private readonly IUserDetailREPO _userDetailRepo;

        public UserDetailSERVICE()
        {
              _userDetailRepo = new UserDetailREPO();   
        }

        public int MaileGoreIdGonder()
        {
            return _userDetailRepo.EmailToId(); 
        }
    }
}
