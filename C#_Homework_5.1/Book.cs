using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_5._1
{
    internal class Book : ICloneable //: IComparable
    {
        protected string name { get; set; }
        protected string author { get; set; }
        protected string publish { get; set; }
        protected int pages { get; set; }
        protected int year { get; set; }

        public Book() : this(null, null, null, 0, 0) { }
        public Book(string n, string au, string pu, int pa, int y)
        {
            name = n;
            author = au;
            publish = pu;

            if (pages < 0)
            {
                throw new PageException("Кол-во страниц не может быть отрицательным");
            }
            if (year < 0)
            {
                throw new YearException("Год не может быть отрицательным");
            }

            pages = pa;
            year = y;
        }

        public void Show()
        {
            Console.WriteLine("\n{0}, {1}, {2}, {3}, {4}", name, author, publish, pages, year);
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Book)
        //    {
        //        return name.CompareTo((obj as Book).name);
        //        throw new NotImplementedException();
        //    }
        //}

        public class SortByName : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if(obj1 is Book && obj2 is Book)
                    return(obj1 as Book).name.CompareTo((obj2 as Book).name);
                throw new NotImplementedException();
            }
        }

        public class SortByAuthor : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).author.CompareTo((obj2 as Book).author);
                throw new NotImplementedException();
            }
        }

        public class SortByPublish : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).publish.CompareTo((obj2 as Book).publish);
                throw new NotImplementedException();
            }
        }

        public class SortByPage : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).pages.CompareTo((obj2 as Book).pages);
                throw new NotImplementedException();
            }
        }

        public class SortByYear : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).year.CompareTo((obj2 as Book).year);
                throw new NotImplementedException();
            }
        }

        public object Clone()
        {
            return new Book(name, author, publish, pages, year);
        }
    }
}
