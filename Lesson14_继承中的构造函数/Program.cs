namespace Lesson14_继承中的构造函数
{

    #region 知识点一 继承中的构造函数 基本概念
    //特点
    //当申明一个子类对象时
    //先执行父类的构造函数
    //再执行子类的构造函数

    //注意：
    //1.父类的无参构造 很重要
    //2.子类可以通过base关键字 代表父类 调用父类的构造
    #endregion

    #region 知识点二 继承中构造函数的执行顺序
    //父类的父类的构造-->。。。父类构造-->。。。-->子类构造

    class GameObject
    {
        public GameObject()
        {
            Console.WriteLine("GameObject构造函数");
        }
    }

    class Player:GameObject
    {
        public Player()
        {
            Console.WriteLine("Player构造函数");
        }
    }

    class  MainPlayer: Player
    {

        public int aa = 10;
        public MainPlayer()
        {
            Console.WriteLine("MainPlayer构造函数");
        }
    }
    #endregion

    #region 父类的无参构造函数很重要
    //子类实例化时，默认自动调用的是父类的无参构造 所以如果父类的无参构造被顶掉会报错
    class Father
    {

        //public Father()
        //{

        //}

        public Father(int i)
        {
            Console.WriteLine("Father构造");
        }
    }

    class Son : Father
    {
        #region 知识点四 通过base调用指定父类构造
        public Son(int i ):base(i)
        {
            
        }

        public Son(int i, string s) : this(i)
        { 

        }
        #endregion
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson14_继承中的构造函数");

            GameObject go = new MainPlayer();

            int pp = (go as MainPlayer).aa;
            Console.WriteLine(pp);
        }
    }
}