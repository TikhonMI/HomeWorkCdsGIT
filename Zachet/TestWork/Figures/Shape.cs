
namespace Figures
{
    abstract class Shape: IComparable
    {
        protected static int numberOfFigure = 0; //Кол-во фигур    
        
        protected string name; //Имя
        protected string collor; //Цвет
        protected double perimeter; //Периметр
        protected double area; //Площадь          

        public Shape(string collor = "White") 
        {            
            this.collor = collor;
            numberOfFigure++;
        }

        public string GetName() => name; 
        public string GetCollor() => collor; 
        public double GetPerimeter() => perimeter; 
        public double GetArea() => area; 
        public int GetNumberOfFigure() => numberOfFigure;

        int IComparable.CompareTo(object obj)
        {
            Shape it = (Shape)obj;
            if (this.area == it.area) { return 0; }
            else if (this.area > it.area) { return 1; }
            else { return -1; }
        }
    }
    
}
