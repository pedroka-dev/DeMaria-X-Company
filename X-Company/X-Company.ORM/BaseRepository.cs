using Microsoft.EntityFrameworkCore;
using X_Company.Domain;

namespace X_Company.ORM
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected readonly XCompanyDBContext db;
        protected readonly DbSet<T> dbSet;

        protected BaseRepository(XCompanyDBContext db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }

        public bool Insert(T registro)
        {
            try
            {
                dbSet.Add(registro);
                db.SaveChanges();
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
                var entity = dbSet.Find(id);
                db.Entry(entity).CurrentValues.SetValues(registro);
                db.SaveChanges();
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
                    db.SaveChanges();
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
    }
}
