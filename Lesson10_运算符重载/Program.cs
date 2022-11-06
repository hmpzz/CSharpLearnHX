namespace Lesson10_运算符重载
{
    internal class Program
    {

        #region 基本语法
        //public static 返回类型 operator 运算符(参数列表)
        #endregion

        #region 实例
        class Point
        {
            public int x;
            public int y;

            public static Point operator +(Point p1, Point p2)
            { 
                Point p = new Point();
                p.x = p1.x + p2.x;
                p.y = p1.y + p2.y;
                return p;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson10_运算符重载");

            #region 使用

            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 1;
            p1.y = 2;
            p2.x = 10;
            p2.y = 20;

            Point p3 = p1 + p2;
            Console.WriteLine($@"x:{p3.x},y:{p3.y}");
            #endregion
        }
    }
}