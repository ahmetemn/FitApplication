using Di_Station.DATA.Abstract;
using Di_Station.DATA.Enums;
using Di_Station.REPO.ConcreteREPO;
using Di_Station.REPO.Intefaces;
using Di_Station.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.Service.Concrate
{
    public class BaseDietService<T> : IBaseDietService<T> where T : BaseDiet
    {
        private readonly IBaseDietREPO<T> _baseDietREPO;


        public BaseDietService()
        {
             _baseDietREPO = new BaseDietREPO<T>();
          
        }

        public int Create(T entity)
        {
            return  _baseDietREPO.Create(entity);   
        }

        public int Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Deleted; 
            return _baseDietREPO.Update(entity);    
        }

        public List<T> GetAll()
        {
            return _baseDietREPO.GetAll();  
        }

        public List<T> GetAllActive(Func<T, bool> expression)
        {

            return _baseDietREPO.GetAllWhere(x => x.Status != Status.Deleted); 
                
        }

        public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {

            return _baseDietREPO.GetAllWhere(expression); 
        }

        public T GetById(int id)
        {
            return _baseDietREPO.GetById(id); 
        }

        public int Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;  
            entity.Status = Status.Updated;
            return _baseDietREPO.Update(entity);
        }
    }

}
