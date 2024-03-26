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
                        name = "Your Skin Micellar Water",
                        shortDesc = "Мицеллярная вода с витамином Е, 250 мламином Е, 250 мл",
                        longDesc = "Мицеллярная вода бережно и эффективно удаляет загрязнения с кожи лица и области вокруг глаз. Мицеллы и витамин Е, входящие в состав, мягко растворяют макияж, не нарушают гидролипидный баланс и увлажняют.",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzU2Ny81NjdjZTljNDBkNjZhMTgwYTMwZWU2NDQxOGM2NGMyYy5qcGc.jpg",
                        price = 345,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "Spa Rituals Amber & Tonka Cream",
                        shortDesc = "Крем-баттер для тела с ароматом амбры и бобов тонка, 250 г",
                        longDesc = "Крем-баттер для тела с ароматом амбры и бобов тонка тает на коже, интенсивно увлажняет ее, повышает упругость и эластичность. Ценные масла глубоко проникают в кожу и питают ее изнутри, смягчают, улучшают тон.",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzMyZC8zMmRmNDc1NDQ4YzBjZDQ2OTZiYjlmNzNmMGI3ZmM2NC5qcGc.jpg",
                        price = 490,
                        isFavourit = false,
                        available = false,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                     new Cosmetics
                    {
                        name = "SPA RITUALS Aer Body Milk",
                        shortDesc = "Тонизирующее молочко для тела с экстрактами орхидеи и готу колы, 200 мл",
                        longDesc = "Это молочко, словно глоток свежего воздуха, наполнит тело активной жизненной энергией и подарит заряд бодрости.",
                        img = "https://image.mixit.ru/insecure/background:fff/resizing_type:fill/width:1120/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrL2FiNC9hYjQ0OTlhNmE2MWIyM2IwY2U4ZjJkZTNjZDViMzA4ZC5qcGc.webp",
                        price = 495,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "FAT BREAKING SET CRYO Body Wrap",
                        shortDesc = "Антицеллюлитное обертывание с охлаждающим эффектом, 200 мл",
                        longDesc = "Охлаждающие средства устранят все несовершенства, преобразят фигуру, сделают кожу супергладкой и упругой. Долговременная свежесть и заряд бодрости обеспечены!",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzgxNS84MTU0NDE1ZDljYjM3NzlkNWY1ZWYzMDRlMzMzZDJlNi5qcGc.jpg",
                        price = 445,
                        isFavourit = false,
                        available = false,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "MIXIT Shampoo Collagen & Biotin",
                        shortDesc = "Восстанавливающий шампунь для волос с коллагеном и биотином, 1000 мл",
                        longDesc = "Восстанавливающий шампунь для волос с коллагеном и биотином бережно очищает кожу головы, регулирует выработку себума, продлевая свежесть.",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrL2FlNS9hZTVmMTNhZWFjYWRlZTVmYmJlNTVmZDQxNzMxZjc2OS5qcGc.jpg",
                        price = 599,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.First()
                    },

                    new Cosmetics
                    {
                        name = "MIXIT Make Up Longwearing lip pencil",
                        shortDesc = "MIXIT Make Up Стойкий карандаш для губ тон 001, 0,28 г",
                        longDesc = "Создайте стойкий и привлекательный макияж губ с помощью карандаша светло-бежевого цвета с теплым подтоном.",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzAzZi8wM2Y1NDE2MDQ3OTBjMjYzMjVjZWMzYjE1ZGYxZWI3ZS5qcGc.jpg",
                        price = 400,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.Last()
                    },

                     new Cosmetics
                    {
                        name = "MIXIT Make up Lip Glass, 3,2 ml",
                        shortDesc = "Блеск для губ «Жидкое стекло» , 3,2 мл",
                        longDesc = "Прозрачный блеск для губ с эффектом «Жидкого стекло» – это идеальный глянец и роскошный блеск. Уникальная формула средства обеспечивает комплексный уход за губами.",
                        img = "<https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzA4ZS8wOGU2YWUyNDE5Mzc0NzYyYjhjZTFmN2Q4NmMyMzJhYy5qcGc.jpg",
                        price = 455,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.Last()
                    },

                    new Cosmetics
                    {
                        name = "MIXIT Make Up Ultra black Volume Mascara",
                        shortDesc = "Ультрачерная тушь для ресниц с эффектом объема, 9,8 мл",
                        longDesc = "Ультрачерная тушь для ресниц с эффектом объема – это ваш секрет изумительного изгиба и выразительного взгляда!",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrL2E2Ni9hNjY3NzM2NTI3NDNkZGE2ZWQ4NTZjMmZhOWI4YWFhNi5qcGc.jpg",
                        price = 500,
                        isFavourit = false,
                        available = false,
                        Category = _categoryCosmetic.AllCategories.Last()
                    },

                    new Cosmetics
                    {
                        name = "EUPHORIA Holographic Tears 15 ml",
                        shortDesc = "Голографический блестящий глиттер для лица и тела, 15 мл",
                        longDesc = "Голографические блёстки для создания невероятно красивого макияжа. Для тех, кто хочет не только «блистательный» взгляд, но и ослепительно красивый образ.",
                        img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzA3NC8wNzQwZWRkODk1ZjM4OGQ0ZGM3ZTM1Y2I3NTJiMWY3NC5qcGc.jpg",
                        price = 295,
                        isFavourit = true,
                        available = true,
                        Category = _categoryCosmetic.AllCategories.Last()
                    },

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

