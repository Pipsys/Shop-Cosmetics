using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.interfaces;
using Shop_Cosmetics.Data.Models;

namespace Shop_Cosmetics.Data.mocks
{
    public class MockCategory : ICosmeticsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category{ categoryName = "Гигиенические средства", desc = "Необходимые для поддержания чистоты"},
                    new Category{ categoryName = "Косметические средства", desc = "Декоративная косметика и ряд вспомогательных продуктов"},
                    
                };
            }
        }

    }
}