using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        List<Instructor> GetAll();
        void Delete (Instructor instructor);
        void Update(Instructor instructor);


    }
}
