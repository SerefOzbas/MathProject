using Bll.Abstract;
using Dal.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Delete(Category entity)
        {
            _categoryDal.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Category category = _categoryDal.Get(a => a.ID == entityID);
            Delete(category);
        }

        public Category Get(int entityID)
        {
            return _categoryDal.Get(a => a.ID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDal.GetAll().ToList();
        }

        public void Insert(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
