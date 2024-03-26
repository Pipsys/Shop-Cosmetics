using Shop_Cosmetics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.interfaces;
using Shop_Cosmetics.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Cosmetics.Controllers
{
    public class CosmeticsController : Controller
    {
        private readonly IAllCosmetics _allCosmetics;
        private readonly ICosmeticsCategory _allCategory;

        public CosmeticsController(IAllCosmetics iAllCosmetics, ICosmeticsCategory iCosmeticsCat)
        {
            _allCosmetics = iAllCosmetics;
            _allCategory = iCosmeticsCat;
        }


        public ViewResult List()
        {
            ViewBag.Title = "Страница с косметикой";
            CosmeticsListViewModel obj = new CosmeticsListViewModel();
            obj.allCosmetics = _allCosmetics.cosmetics;
            obj.currCaterogy = "Косметика";

            return View(obj);
        }
    }
}
