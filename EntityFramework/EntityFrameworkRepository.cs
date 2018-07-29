using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Layer.Data.Abstract;
using Layer.Entity.Abstract;

namespace Layer.Data.Concart.EntityFramework
{
    public class EntityFrameworkRepository<TEntites, TContext> : IRepository<TEntites> where TEntites :
        class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntites entity)
        {
            using (TContext context = new TContext())
            {
                var value = context.Entry(entity);
                value.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntites entity)
        {
            using (TContext context = new TContext())
            {
                var value = context.Entry(entity);
                value.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntites> GetAll(Expression<Func<TEntites, bool>> result = null)
        {
            using (TContext context = new TContext())
            {
                return result == null
                    ? context.Set<TEntites>().ToList()
                    : context.Set<TEntites>().Where(result).ToList();
            }
        }

        public void Update(TEntites entity)
        {
            using (TContext context = new TContext())
            {
                var value = context.Entry(entity);
                value.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
