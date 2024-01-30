using Di_Station.DATA.Concrete;
using Di_Station.REPO.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.REPO.ConcreteREPO
{
    public class MealREPO : BaseDietREPO<Meal>, IMealREPO
    {
        public List<Meal> GetAllOrderByName()
        {
            throw new NotImplementedException();
        }
    }
}
