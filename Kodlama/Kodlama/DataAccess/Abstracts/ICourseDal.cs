using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        List<Course> GetAll();
        void Delete (Course course);
        void Update(Course course);


    }
}
