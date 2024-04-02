using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Shop_Cosmetics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Shop_Cosmetics.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Cosmetics.Any())
            {
                content.AddRange(
                        new Cosmetics
                        {
                            name = "Your Skin Micellar Water",
                            shortDesc = "Мицеллярная вода с витамином Е, 250 мламином Е, 250 мл",
                            longDesc = "Мицеллярная вода бережно и эффективно удаляет загрязнения с кожи лица и области вокруг глаз. Мицеллы и витамин Е, входящие в состав, мягко растворяют макияж, не нарушают гидролипидный баланс и увлажняют.",
                            img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzU2Ny81NjdjZTljNDBkNjZhMTgwYTMwZWU2NDQxOGM2NGMyYy5qcGc.jpg",
                            price = 345,
                            isFavourit = true,
                            available = true,
                            Category = Categories["Гигиенические средства"]
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
                            Category = Categories["Гигиенические средства"]
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
                             Category = Categories["Гигиенические средства"]
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
                            Category = Categories["Гигиенические средства"]
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
                            Category = Categories["Гигиенические средства"]
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
                            Category = Categories["Косметические средства"]
                        },

                         new Cosmetics
                         {
                             name = "MIXIT Make up Lip Glass, 3,2 ml",
                             shortDesc = "Блеск для губ «Жидкое стекло» , 3,2 мл",
                             longDesc = "Прозрачный блеск для губ с эффектом «Жидкого стекло» – это идеальный глянец и роскошный блеск. Уникальная формула средства обеспечивает комплексный уход за губами.",
                             img = "https://image.mixit.ru/insecure/resizing_type:fill/width:560/aHR0cHM6Ly9taXhpdC5ydS91cGxvYWQvaWJsb2NrLzA4ZS8wOGU2YWUyNDE5Mzc0NzYyYjhjZTFmN2Q4NmMyMzJhYy5qcGc.jpg",
                             price = 455,
                             isFavourit = true,
                             available = true,
                             Category = Categories["Косметические средства"]
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
                            Category = Categories["Косметические средства"]
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
                            Category = Categories["Косметические средства"]
                        }
                    );
            }
            content.SaveChanges();
        }


        public static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Гигиенические средства", desc = "Необходимые для поддержания чистоты"},
                        new Category{ categoryName = "Косметические средства", desc = "Декоративная косметика и ряд вспомогательных продуктов"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                    return category;
           
            }
        }
    }
}
