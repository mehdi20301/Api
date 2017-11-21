using DataModel.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Services.Interfaces
{
    public interface ITranslateService
    {
        void Insert(Translate translate);

        IQueryable<Translate> GetTranslate(string Question);
    }
}
