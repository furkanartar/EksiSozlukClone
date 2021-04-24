using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IDataResult<List<About>> GetAll();
        IResult Add(About about);
        IResult Update(About about);
        IResult Delete(About about);
    }
}
