using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<CategoryObject> GetCategoryList() => CategoryDAO.Instance.GetCategoryList();
    }
}
