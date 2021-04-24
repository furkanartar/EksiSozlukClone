using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public IResult Add(Content content)
        {
            _contentDal.Add(content);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Content content)
        {
            _contentDal.Delete(content);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Content>> GetAll()
        {
            return new SuccessDataResult<List<Content>>(_contentDal.GetAll(), "Listelendi");
        }

        public IResult Update(Content content)
        {
            _contentDal.Update(content);
            return new SuccessResult("Güncellendi");
        }
    }
}
