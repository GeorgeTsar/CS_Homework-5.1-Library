using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_5._1
{
    class BookException: ApplicationException
    {
        public BookException(string msg) : base(msg) { }
    }
    class PageException : BookException
    {
        public PageException(string msg) : base(msg) { }
    }

    class YearException : BookException
    {
        public YearException(string msg) : base(msg) { }
    }
}
