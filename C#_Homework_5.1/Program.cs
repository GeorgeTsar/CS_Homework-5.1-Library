using C__Homework_5._1;
using System;
using System.Runtime.ConstrainedExecution;

class MainClass
{
    public static void Main()
    {
        Book[] B = new Book[6];
        Console.WriteLine("Книги:");
        B[0] = new Book("Над пропастью во ржи", "Джером Д. Сэлинджер", "ЭКСМО", 671, 2008);
        B[1] = new Book("Террор", "Дэн Симмонс", "Азбука", 760, 2020);
        B[2] = new Book("Гроздья гнева", "Джон Стейнбек", "Азбука", 605, 2019);
        B[3] = new Book("Человек в высоком замке", "Филип К. Дик", "ЭКСМО", 408, 2018);
        B[4] = new Book("Щегол", "Дона Тартт", "АСТ", 828, 2013);
        B[5] = new Book("Мир, полный демонов", "Карл Саган", "Династия", 523, 2016);
        foreach (Book temp in B)
            temp.Show();

        Array.Sort(B, new Book.SortByName());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine("Книги, упорядоченные по имени: ");
        foreach (Book temp in B)
            temp.Show();

        Array.Sort(B, new Book.SortByAuthor());
        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine("Книги, упорядоченные по автору: ");
        foreach (Book temp in B)
            temp.Show();
    }
}