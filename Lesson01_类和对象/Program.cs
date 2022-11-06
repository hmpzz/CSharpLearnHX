namespace Lesson01_类和对象
{


    #region 类申明的语法
    class 类名
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }

    class GameObject
    { 
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            GameObject A = new GameObject();
            GameObject B = A;
            B = null;


            GameObject C = new GameObject();
            GameObject D = C;
            D=new GameObject();
        }
    }
}