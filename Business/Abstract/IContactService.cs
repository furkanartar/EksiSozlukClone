using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
    }
}
