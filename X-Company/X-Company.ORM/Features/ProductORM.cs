using X_Company.Domain;
using X_Company.Domain.Features;

namespace X_Company.ORM.Features
{
    public class ProductORM : BaseRepository<Product>, IRepository<Product>
    {
        protected ProductORM(XCompanyDBContext db) : base(db)
        {
        }
    }
}
