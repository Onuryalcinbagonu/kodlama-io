using Kodlama.DataAccess.Abstracts;
using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.Business.Abstracts
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll(); 
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
    }
}
