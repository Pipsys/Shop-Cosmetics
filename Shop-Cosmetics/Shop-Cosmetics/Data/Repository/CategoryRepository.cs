using Shop_Cosmetics.Data.interfaces;
using Shop_Cosmetics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop_Cosmetics.Data.Repository
{
    public class CategoryRepository : ICosmeticsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;

    }
}
