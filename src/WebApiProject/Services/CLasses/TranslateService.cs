using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel.Data.Model;
using WebApiProject.Services.Interfaces;
using DataModel.Data.Context;

namespace WebApiProject.Services.CLasses
{
    public class TranslateService : ITranslateService
    {
        private DataModel.UnitOfWork.Classes.UnitOfWorkClass _UnitOfWork = null;

        public TranslateService(WebApiDBContext context)
        {
            _UnitOfWork = new DataModel.UnitOfWork.Classes.UnitOfWorkClass(context);
        }

        public IQueryable<Translate> GetTranslate(string Question)
        {
            return _UnitOfWork.TranslateRepository.FetchAll(x => x.Question == Question);
        }

        public void Insert(Translate translate)
        {
            _UnitOfWork.TranslateRepository.Insert(translate);
            _UnitOfWork.SaveDataToDataBase();
        }
    }
}
