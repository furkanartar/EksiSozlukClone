using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public IResult Add(Heading heading)
        {
            _headingDal.Add(heading);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Heading heading)
        {
            _headingDal.Delete(heading);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Heading>> GetAll()
        {
            return new SuccessDataResult<List<Heading>>(_headingDal.GetAll(), "Listelendi");
        }

        public IResult Update(Heading heading)
        {
            _headingDal.Update(heading);
            return new SuccessResult("Güncellendi");
        }
    }
}
