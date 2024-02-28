using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        List<Category> GetAll();
        void Delete (Category category);
        void Update(Category category);


    }
}
