using Kodlama.DataAccess.Abstracts;
using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instractor = new Instructor();
            instractor.Id = Guid.NewGuid();
            instractor.Name = "Engin Demiroğ";
            instractor.CreatedDate = DateTime.Now;
            Instructor instractor2 = new Instructor();
            instractor2.Id = Guid.NewGuid();
            instractor2.Name = "Ali Veli";
            instractor2.CreatedDate = DateTime.Now;
            instructors = new List<Instructor>() { instractor, instractor2 };
        }
        public void Add(Instructor instractor)
        {
            instractor.CreatedDate= DateTime.Now;
            instructors.Add(instractor);
        }

        public void Delete(Instructor instractor)
        {
            instractor.DeleteDate= DateTime.Now;    
            instructors.Remove(instractor);
            Console.WriteLine("Eğitmen Silindi");
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            instructor.Name = "(Update) Sadık Ali";
            instructor.UpdatedDate = DateTime.Now;
            instructor.ImageUrl = "(Update) Eğitmen Fotoğraf";
      
        }
    }
}
