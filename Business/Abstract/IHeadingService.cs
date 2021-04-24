using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHeadingService
    {
        IDataResult<List<Heading>> GetAll();
        IResult Add(Heading heading);
        IResult Update(Heading heading);
        IResult Delete(Heading heading);
    }
}
