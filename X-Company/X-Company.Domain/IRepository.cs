
namespace X_Company.Domain
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Insert(T registro);
        bool Update(int id, T registro);
        bool Delete(int id);
        T SelectById(int id);
        List<T> SelectAll();
        bool Exists(int id);

    }
}
