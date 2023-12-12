using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly Context _contex;

        public GenericUowRepository(Context contex)
        {
            _contex = contex;
        }

        public T GetById(int id)
        {
            return _contex.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _contex.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
           _contex.UpdateRange(t);
        }

        public void Update(T t)
        {
            _contex.Update(t);
        }
    }
}
