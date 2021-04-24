using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWriterService
    {
        IDataResult<List<Writer>> GetAll();
        IResult Add(Writer writer);
        IResult Update(Writer writer);
        IResult Delete(Writer writer);
    }
}
