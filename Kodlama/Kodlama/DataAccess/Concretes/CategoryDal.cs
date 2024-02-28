using Kodlama.DataAccess.Abstracts;
using Kodlama.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.Id = Guid.NewGuid();
            category.Name = "Programlama";
            category.CreatedDate = DateTime.Now;
            Category category2 = new Category();
            category2.Id = Guid.NewGuid();
            category2.Name = "Grafik Tasarım";
            category2.CreatedDate = DateTime.Now;
            categories = new List<Category>() { category, category2 };
        }
        public void Add(Category category)
        {
            category.CreatedDate = DateTime.Now;
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            category.DeleteDate = DateTime.Now;
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            category.Name = "(Update) Programlamaya Giriş için Temel Kurs";
            category.UpdatedDate = DateTime.Now;

        }
    }
}
