using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    internal interface IRepository<T> where T:IBaseInterface
    {
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);

        T Get(Predicate<T> filter = null);
        List<T> GetAll(Predicate<T> filter = null);

        int Count();
    }
}
