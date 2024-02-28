using Kodlama.DataAccess.Abstracts;
using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Concretes
{

    public class CourseDal : ICourseDal
    {
        List<Course> courses;
   
        public CourseDal(List<Instructor> instructors, List<Category> categories)
        {
            Course course = new Course();
            course.Id= Guid.NewGuid();
            course.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course.CreatedDate= DateTime.Now;
            course.ImageUrl = "image.jpg";
            course.Price = 0;
            course.Description = "Lorem Ipsum";
            course.CategoryId=categories.First().Id;
            course.InstractorId= instructors.First().Id;

            Course course2 = new Course();
            course2.Id = Guid.NewGuid();
            course2.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course2.CreatedDate = DateTime.Now;
            course2.ImageUrl = "image-net.jpg";
            course2.Price = 0;
            course2.Description = "Lorem Ipsum .Net";
            course2.CategoryId = categories.First().Id;
            course2.InstractorId = instructors.First().Id;

            Course course3 = new Course();
            course3.Id = Guid.NewGuid();
            course3.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)";
            course3.CreatedDate = DateTime.Now;
            course3.ImageUrl = "image-java.jpg";
            course3.Price = 0;
            course3.Description = "Lorem Ipsum .Java";
            course3.CategoryId = categories.First().Id;
            course3.InstractorId = instructors.First().Id;
            courses =new List<Course> { course,course2 ,course3};
        }
        public void Add(Course course)
        {
            course.CreatedDate= DateTime.Now;
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            course.DeleteDate= DateTime.Now;
            courses.Remove(course);
            Console.WriteLine("Kurs Silindi");
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            course.Name = "(Update) Programlamaya Giriş için Temel Kurs";
            course.UpdatedDate= DateTime.Now;
            course.Description= "(Update) Açıklama";
            course.ImageUrl = "(Update) image url";
            course.Price = 123.21m;

        }
    }
}
