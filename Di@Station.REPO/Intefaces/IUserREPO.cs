using Di_Station.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.REPO.Intefaces
{
	public interface IUserREPO:IBaseDietREPO<User>
	{
        List<User> GetSurnameUser(int id);
    }
}
