
namespace DistanceInch
{   
    internal class Distance
    {
        private int foot;
        private int inch;

        public Distance (int foot, int inch)
        {
            this.foot = foot;
            this.inch = inch;
        }
        private int AllInch()
        {
            return foot * 12 + inch;
        }
        public static Distance operator + (Distance d1, Distance d2)
        {
            int allInch = (d1.foot + d2.foot) * 12 + d1.inch + d2.inch;
            int newFoot = allInch / 12;
            int newInch = allInch % 12;
            return new Distance (newFoot, newInch);
        }
        public static Distance operator -(Distance d1, Distance d2)
        {            
            int allInch = d1.AllInch() - d2.AllInch();
            int newFoot = allInch / 12;
            int newInch = allInch % 12;
            return new Distance(newFoot, newInch);
        }
        public static bool operator == (Distance d1, Distance d2) => (_ = d1.AllInch() == d2.AllInch()? true: false);
       
        public static bool operator !=(Distance d1, Distance d2) => (_ = d1.AllInch() != d2.AllInch()? true : false);
        
        public override string ToString() => $"{foot}'-{inch}\"";

    }
    
}
