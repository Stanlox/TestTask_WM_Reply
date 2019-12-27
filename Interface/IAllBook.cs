using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM_Reply.Models;

namespace WM_Reply.Interface
{
    interface IAllBook
    {
        IEnumerable<Book> Books { get;  }

    }
}
