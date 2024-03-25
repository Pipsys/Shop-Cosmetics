using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.interfaces;
using Shop_Cosmetics.Data.Models;

namespace Shop_Cosmetics.Data.mocks
{
    public class MockCosmetics : IAllCosmetics
    {
        private readonly ICosmeticsCategory _categoryCosmetic = new MockCategory();

        public IEnumerable<Cosmetics> cosmetics
        {
            get
            {
                return new List<Cosmetics>
                {
                    new Cosmetics { name = "Spa Rituals Amber & Tonka Cream", shortDesc = "", longDesc = "", img = "", price = 490, isFavourit = true, available = true, Category = _categoryCosmetic.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Cosmetics> getFavCosmetics { get; set; }

        public Cosmetics getObjectCosmetics(int cosmeticsId)
        {
            throw new NotImplementedException();
        }
    }
}

