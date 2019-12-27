using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM_Reply.Interface;
using WM_Reply.Models;

namespace WM_Reply.mocks
{
    public class MockBooks : IAllBook
    {
        private readonly IBookCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book { Name= "CLR Via C#",
                        shortDesc ="Эта книга, выходящая в четвертом издании и уже ставшая классическим учебником по программированию, подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework",
                        longDesc ="Написанная признанным экспертом в области программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET Framework компании Microsoft, книга научит вас создавать по-настоящему надежные приложения любого вида, в том числе  использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т. д.",
                        img ="https://www.google.com/search?q=clr+via+c%23&source=lnms&tbm=isch&sa=X&ved=2ahUKEwighqCnv9XmAhVltIsKHYB5BKAQ_AUoAXoECA4QAw#imgrc=eMFzOrV8ndsiXM:",
                        Category = _categoryBooks.AllCategories.First() },
                    new Book
                    {
                        Name="C# 7 и .NET Core. Кросс-платформенная разработка для профессионалов",
                        shortDesc="Отличный вариант для начинающих",
                        longDesc="C# 7 - новая мощная и многофункциональная версия популярнейшего языка программирования от Майкрософт. Вы встретите немало интересных книг по языку C# и платформе .NET, однако, в большинстве из них лишь мельком рассматривается столь важный аспект, как кросс-платформенная разработка.",
                        img="https://www.google.com/search?biw=1920&bih=937&tbm=isch&sa=1&ei=FM0FXpLuGbKGwPAPm70d&q=c%23+7+%D0%B8+.net+core+rybuf&oq=c%23+7+%D0%B8+.net+core+rybuf&gs_l=img.3...5510.6947..7139...0.0..0.77.532.8......0....1..gws-wiz-img.......0i8i30j0i24.Tekuh8HwZgs&ved=0ahUKEwiSyJOkwNXmAhUyAxAIHZteBwAQ4dUDCAc&uact=5#imgrc=Jrzu6tyKpxeyyM:",
                        Category=_categoryBooks.AllCategories.Last()
                    },
                    new Book
                    {
                        Name="C# 4.0. Полное руководство ",
                        shortDesc="Это самая большая часть книги, в которой описываются ключевые слова, синтаксис и средства данного языка, а также операции ввода-вывода и обработки файлов, рефлексия и препроцессор.",
                        longDesc="Книга рассчитана на широкий круг читателей, интересующихся программированием на C#. Полностью исправленное и обновленное издание классического руководства по C# 4.0",
                        img="https://www.google.com/search?q=%D0%B3%D0%B5%D1%80%D0%B1%D0%B5%D1%80%D1%82+%D1%88%D0%B8%D0%BB%D0%B4%D1%82+c%23&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiYvYz8wNXmAhVjl4sKHd7ADBAQ_AUoAXoECAsQAw&biw=1920&bih=937#imgrc=Ks97fJ2yXHaRdM:",
                        Category=_categoryBooks.AllCategories.Last()
                    }
                };
            }

        }
    }
}