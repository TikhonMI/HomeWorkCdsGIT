using MyClass;

class Program
{
    public static void Main(string[] args)
    {               
        Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true); //создали книгу

        
        b2.Show();        

        Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
        mag1.TakeItem();
        mag1.Show();
        mag1.IfSubs = true;
        mag1.Subs();

        Console.WriteLine("\n Тестирование полиморфизма");
        Item it; it = b2; it.TakeItem(); it.Return(); it.Show(); it = mag1; it.TakeItem(); it.Return(); it.Show();

        //b2.Show(); //вызвали метод для вывода информации о новой книге
        //Book.SetPrice(12); //установили стоимость аренды книги
        //b2.Show();

        //Item item1 = new Item();
        //item1.Show();
    }
}