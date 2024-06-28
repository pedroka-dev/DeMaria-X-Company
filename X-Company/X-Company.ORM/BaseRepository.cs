using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using X_Company.Domain;

namespace X_Company.ORM
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected readonly XCompanyDBContext dbContext;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(XCompanyDBContext db)
        {
            dbContext = db;
            dbSet = db.Set<T>();
        }

        public bool Insert(T registro)
        {
            try
            {
                dbSet.Add(registro);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public virtual bool Update(int id, T registro)
        {
            try
            {
                registro.Id = id;
                var entity = dbSet.Find(id);
                dbContext.Entry(entity).CurrentValues.SetValues(registro);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                T registro = SelectById(id);
                if (registro != null)
                {
                    dbSet.Remove(registro);
                    dbContext.SaveChanges();
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public virtual T SelectById(int id)
        {
            try
            {
                return dbSet.FirstOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public virtual List<T> SelectAll()
        {
            try
            {
                return dbSet.ToList<T>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async virtual Task<List<T>> SelectAllIncluding(params Expression<Func<T, object>>[] includeProperties)   //Used to get objects with relationship
        {
            IQueryable<T> query = dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }


        public bool Exists(int id)
        {
            try
            {
                return dbSet.ToList().Exists(x => x.Id == id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void DisposeDb()
        {
            dbContext.Dispose();
        }
    }
}
