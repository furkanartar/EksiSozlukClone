using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContentService
    {
        IDataResult<List<Content>> GetAll();
        IResult Add(Content content);
        IResult Update(Content content);
        IResult Delete(Content content);
    }
}
