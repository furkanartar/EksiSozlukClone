using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.EntityFramework.Abstract
{
    public interface IContactDal : IEntityRepository<Contact>
    {
    }
}
