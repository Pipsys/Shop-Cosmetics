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
                    new Cosmetics
                    {
                        name = "Spa Rituals Amber & Tonka Cream",
                        shortDesc = "Увлажнение, Питание и восстановление",
                        longDesc = "Увлажняющий крем для рук и тела с ароматом амбры и бобов тонка, 250 г",
                        img = "https://pcdn.goldapple.ru/p/p/19000170605/web/696d67416464318db65b35e4fd89ffullhd.webp",
                        price = 490,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "SPA RITUALS Aer Body Milk",
                        shortDesc = "Увлажнение, Тонизирование",
                        longDesc = "Тонизирующее молочко для тела с экстрактами орхидеи и готу колы, 200 мл",
                        img = "https://image.mixit.ru/insecure/background:fff/resizing_type:fill/width:1120/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrL2FiNC9hYjQ0OTlhNmE2MWIyM2IwY2U4ZjJkZTNjZDViMzA4ZC5qcGc.webp",
                        price = 495,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "MIXIT Make Up Longwearing lip pencil color 001",
                        shortDesc = "Стойкий карандаш",
                        longDesc = "MIXIT Make Up Стойкий карандаш для губ тон 001, 0,28 г",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzAzZi8wM2Y1NDE2MDQ3OTBjMjYzMjVjZWMzYjE1ZGYxZWI3ZS5qcGc.jpg",
                        price = 400,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.Last()
                    }

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

