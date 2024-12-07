using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace C__Homework_5._1
{
    class Library : IEnumerable
    {
        Book[] arr;
        public Library(int len)
        {
            arr = new Book[len];
            for(int i = 0; i < len; i++)
            {
                arr[i] = new Book();
            }
        }

        public Library() : this(1) { }
        public Library(Book[] books)
        {
            arr = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
            {
                arr[i] = new Book(books[i].name, books[i].author, books[i].publish, books[i].pages, books[i].year);
            }
        }

        //public void InputClub()
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i].Input();
        //    }
        //}

        public void ShowBooks()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
    }
}
