using Kodlama.Business.Abstracts;
using Kodlama.DataAccess.Abstracts;
using Kodlama.DataAccess.Concretes;
using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            List<Instructor> instructors = instructorManager.GetAll();
            List<Category> categories = categoryManager.GetAll();

            CourseManager courseManager = new CourseManager(new CourseDal(instructors, categories));
            List<Course> courses = courseManager.GetAll();



            Course(instructors, categories, courseManager, courses);

            Category(categoryManager, categories);

            Instructor(instructorManager, instructors);

            Console.ReadLine();
        }

        private static void Instructor(InstructorManager instructorManager, List<Instructor> instructors)
        {
            Console.WriteLine("Instructor Create ----------------");
            Console.WriteLine(" ");

            instructorManager.Add(new Instructor() { Id = Guid.NewGuid(), Name = "Instructor", CreatedDate = DateTime.Now }); ;


            Console.WriteLine("Instructor Read ----------------");
            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine("**********************************");
                    Console.WriteLine(" ");

                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Instructor Delete---------");
            Console.WriteLine(" ");


            instructorManager.Delete(instructors.First());
            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(" ");

                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Category Update---------");
            Console.WriteLine(" ");

            instructorManager.Update(instructors.First());
            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(" ");
                }
            }
        }

        private static void Category(CategoryManager categoryManager, List<Category> categories)
        {
            Console.WriteLine("Category Create ----------------");
            Console.WriteLine(" ");

            categoryManager.Add(new Category() { Id = Guid.NewGuid(), Name = "Category", CreatedDate = DateTime.Now }); ;


            Console.WriteLine("Category Read ----------------");
            if (categories.Count > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine("**********************************");
                    Console.WriteLine(" ");

                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Category Delete---------");
            Console.WriteLine(" ");


            categoryManager.Delete(categories.First());
            if (categories.Count > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(" ");

                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Category Update---------");
            Console.WriteLine(" ");

            categoryManager.Update(categories.First());
            if (categories.Count > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(" ");
                }
            }
        }

        private static void Course(List<Instructor> instructors, List<Category> categories, CourseManager courseManager, List<Course> courses)
        {
            Console.WriteLine("Course Create ----------------");
            Console.WriteLine(" ");

            courseManager.Add(new Course() { Id = Guid.NewGuid(), Name = "Course", CreatedDate = DateTime.Now, Description = "New description", ImageUrl = "Image url", Price = 0, CategoryId = categories.First().Id, InstractorId = instructors.First().Id }); ;


            Console.WriteLine("Course Read ----------------");
            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(instructors.Where(id => id.Id == item.InstractorId).ToList().FirstOrDefault().Name);
                    Console.WriteLine(categories.Where(id => id.Id == item.CategoryId).ToList().FirstOrDefault().Name);
                    Console.WriteLine("**********************************");
                    Console.WriteLine(" ");

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Course Delete---------");
            Console.WriteLine(" ");


            courseManager.Delete(courses.First());
            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(instructors.Where(id => id.Id == item.InstractorId).ToList().FirstOrDefault().Name);
                    Console.WriteLine(categories.Where(id => id.Id == item.CategoryId).ToList().FirstOrDefault().Name);
                    Console.WriteLine(" ");

                }
            }



            Console.WriteLine(" ");
            Console.WriteLine("Course Update---------");
            Console.WriteLine(" ");

            courseManager.Update(courses.First());
            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CreatedDate);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(instructors.Where(id => id.Id == item.InstractorId).ToList().FirstOrDefault().Name);
                    Console.WriteLine(categories.Where(id => id.Id == item.CategoryId).ToList().FirstOrDefault().Name);
                    Console.WriteLine(" ");
                }
            }
        }
    }

   
}
