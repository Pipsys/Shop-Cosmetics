using Microsoft.EntityFrameworkCore;
using Shop_Cosmetics.Data.interfaces;
using Shop_Cosmetics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Cosmetics.Data.Repository
{
    public class CosmeticsRepository : IAllCosmetics
    {
        private readonly AppDBContent appDBContent;

        public CosmeticsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Cosmetics> cosmetics => appDBContent.Cosmetics.Include(c => c.Category);

        public IEnumerable<Cosmetics> getFavCosmetics => appDBContent.Cosmetics.Where(p => p.isFavourit).Include(c => c.Category);

        public Cosmetics getObjectCosmetics(int cosmeticsId) => appDBContent.Cosmetics.FirstOrDefault(p => p.id == cosmeticsId);
    }
}
