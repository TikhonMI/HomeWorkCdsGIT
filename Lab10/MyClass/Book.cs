using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Book: Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9; //стоимость аренды за любую книгу

        private bool returnSrok; //Для учета возвращения книги

        public Book(String author, String title, String publisher, int pages, int year) //конструктор, инициализирует все поля объекта
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        //конструктор со ссылкой на конструктор базового класса
        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book() //конструктор по умолчанию
        { }

        static Book() //статический конструктор
        {
            price = 10;
        }              

        public static void SetPrice(double price) //возможность изменить стоимость аренды (обращаются через имя класса)
        {
            Book.price = price;
        }

        public override void Show() //вывод на экран информации о книге / new для явного указания факта скрытия метода базового класса
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}p. в сутки", author, title, year, pages, Book.price);
            base.Show(); //вызов метода Show базового класса
        }

        public double PriceBook(int s) //стоимость аренды за указанное количество суток
        {
            double cust = s * price;
            return cust;
        }

        //метод устанавливающий, что книга сдана в срок
        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
    }
}
