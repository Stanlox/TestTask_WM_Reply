using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM_Reply.Interface;
using WM_Reply.Models;

namespace WM_Reply.mocks
{
    public class MockCategory : IBookCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Для начинающих", desc="Все основыне сведение о языке, которые могут даже самому начинающему писать код с первых дней"},
                    new Category {CategoryName ="Для продвинутых", desc="Книги для опытных программистов, которые могут узнать тонкости той или иной технологии "}
                };
            }
        }
    }
}