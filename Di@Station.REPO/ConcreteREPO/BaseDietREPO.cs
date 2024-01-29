using Di_Station.DATA.Abstract;
using Di_Station.REPO.Intefaces;
using System.Linq.Expressions;

namespace Di_Station.REPO.ConcreteREPO
{
	public class BaseDietREPO<T> : IBaseDietREPO<T> where T : BaseDiet
	{
		public int Create(T entity)
		{
			throw new NotImplementedException();
		}

		public int Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public List<T> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public T GetById(int id)
		{
			throw new NotImplementedException();
		}

		public int Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}