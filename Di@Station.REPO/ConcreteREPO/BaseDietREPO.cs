using Di_Station.DATA.Abstract;
using Di_Station.REPO.Context;
using Di_Station.REPO.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Di_Station.REPO.ConcreteREPO
{
	public class BaseDietREPO<T> : IBaseDietREPO<T> where T : BaseDiet
	{
		private readonly DietContext _dietContext;

        public BaseDietREPO()
        {
				_dietContext = new DietContext();	
        }

        public int Create(T entity)
		{
			if (entity is not null)
			
				_dietContext.Add(entity);
				return _dietContext.SaveChanges();
				throw new Exception("Nesne boş olamaz"); 
		}

		public int Delete(T entity)
		{
				if(entity is not null)
			
				_dietContext.Remove(entity);	
				return _dietContext.SaveChanges();
				throw new Exception("Nesne boş olamaz");

        }

		public List<T> GetAll()
		{
				var list = _dietContext.Set<T>().ToList();
			if (list is not null)
				return list;
			else
				throw new Exception("Böyle bir data yok"); 
		}

		public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
		{
				return _dietContext.Set<T>().Where(expression).ToList();
		}

		public T GetById(int id)
		{
			return _dietContext.Set<T>().Find(id);
		}

		public int Update(T entity)
		{

			//Entry => Context üzerindeki bir varlık üzerinde değişiklik yapmak için kullanılan metoddur . 
			//varlığın değişiklik durumunu kontrol ediyor . 
			_dietContext.Entry(entity).State = EntityState.Modified; 
			return _dietContext.SaveChanges();		
		}
	}
}