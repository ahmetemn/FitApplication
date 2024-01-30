using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.Service.Interface
{
    public  interface IBaseDietService<T> where T:  BaseDiet
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetAllWhere(Expression<Func<T, bool>> expression);
        List<T> GetAllActive(Func<T, bool> expression);
        //List<T> GetPages(int _skip, int take, Func<T, bool> expression = null); 
    }
}
