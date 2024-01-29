using Di_Station.DATA.Abstract;
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
	public class CategoryREPO : BaseDietREPO<Category>, ICategoryREPO
	{
		public int Create(Category entity)
		{
			throw new NotImplementedException();
		}

		public int Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAllWhere(Expression<Func<Category, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public Category GetById(int id)
		{
			throw new NotImplementedException();
		}

		public int Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
