using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    abstract class Item
    {
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;

        //конструктор с параметрами для инициализации объекта хранения
        public Item(long invNumber, bool taken) 
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        //конструктор по умолчанию для инициализации начальными значениями учитывая, что в начале работы предполагается наличие элемента в библиотеке
        public Item() 
        {
            this.taken = true;
        }

        // истина, если этот предмет имеется в библиотеке
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        private void Take()
        {
            taken = false;
        }
        // операция "вернуть"
        abstract public void Return();        

        //метод, выводящий на экран информацию о единице хранения
        public virtual void Show() 
        {
            Console.WriteLine("\n Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }

        public void TakeItem() //реализовали выдачу 
        {
            if (this.IsAvailable())
                this.Take();
        }

        //public void ReturnItem() //реализовали возврат 
        //{
        //    if (this.IsAvailable() == false)
        //        this.Return();
        //}
    }
}
