using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public IResult Add(Writer writer)
        {
            _writerDal.Add(writer);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Writer writer)
        {
            _writerDal.Delete(writer);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Writer>> GetAll()
        {
            return new SuccessDataResult<List<Writer>>(_writerDal.GetAll(), "Listelendi");
        }

        public IResult Update(Writer writer)
        {
            _writerDal.Update(writer);
            return new SuccessResult("Güncellendi");
        }
    }
}
