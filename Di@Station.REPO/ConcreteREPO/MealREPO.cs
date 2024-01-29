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
	internal class MealREPO : BaseDietREPO<Meal>, IMealREPO
	{
		public int Create(Meal entity)
		{
			throw new NotImplementedException();
		}

		public int Delete(Meal entity)
		{
			throw new NotImplementedException();
		}

		public List<Meal> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<Meal> GetAllWhere(Expression<Func<Meal, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public Meal GetById(int id)
		{
			throw new NotImplementedException();
		}

		public int Update(Meal entity)
		{
			throw new NotImplementedException();
		}
	}
}
