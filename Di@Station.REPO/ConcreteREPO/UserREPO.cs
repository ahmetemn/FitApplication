﻿using Di_Station.DATA.Concrete;
using Di_Station.REPO.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.REPO.ConcreteREPO
{
    public class UserREPO : BaseDietREPO<User>, IUserREPO
    {
        public List<User> GetSurnameUser(int id)
        {
           //burada işlem 
        }
    }
}
