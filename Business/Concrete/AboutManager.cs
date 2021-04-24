using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll(), "Listelendi");
        }

        public IResult Update(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult("Güncellendi");
        }
    }
}
