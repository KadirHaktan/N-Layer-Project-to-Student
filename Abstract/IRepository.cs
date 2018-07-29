using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity.Abstract;

namespace Layer.Data.Abstract
{
  public interface IRepository<T> where T:class,IEntity,new()
  {
      List<T> GetAll(Expression<Func<T,bool>> result=null);

      void Add(T entity);
      void Delete(T entity);
      void Update(T entity);


  }
}
