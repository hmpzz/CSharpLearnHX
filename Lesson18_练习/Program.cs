namespace Lesson18_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson18_练习");


            #region 图形题

            TX jX = new JX(10, 12);
            Console.WriteLine(jX.MJ());
            Console.WriteLine(jX.ZC());

            TX zFX = new ZFX(10);
            Console.WriteLine(zFX.MJ());
            Console.WriteLine(zFX.ZC());


            TX yUAN = new YUAN(10);
            Console.WriteLine(yUAN.MJ());
            Console.WriteLine(yUAN.ZC());


            #endregion

            #region 动物题

            Animal person = new Person();
            person.Speak();

            Animal dog = new Dog();
            dog.Speak();

            Animal cat = new Cat();
            cat.Speak();
            #endregion

        }
    }


    #region 图形题
    /// <summary>
    /// 图形类
    /// </summary>
    abstract class TX
    {
        /// <summary>
        /// 面积方法
        /// </summary>
        /// <returns>返回求得的面积</returns>
        public abstract decimal MJ();

        /// <summary>
        /// 周长方法
        /// </summary>
        /// <returns>返回求得的周长</returns>
        public abstract decimal ZC();
    


        
    }

    /// <summary>
    /// 矩形类
    /// </summary>
    class JX : TX
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_Width">宽</param>
        /// <param name="_Height">高</param>
        public JX(decimal _Width, decimal _Height)
        {
            Width = _Width;
            Heigth = _Height;
        }
        /// <summary>
        /// 宽
        /// </summary>
        public decimal Width { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        public decimal Heigth { get; set; }

        /// <summary>
        /// 求面积
        /// </summary>
        /// <returns>返回面积值</returns>
        public override decimal MJ()
        {
            return Width * Heigth;
        }
        /// <summary>
        /// 求周长
        /// </summary>
        /// <returns>返回周长</returns>
        public override decimal ZC()
        {
            return (Width + Heigth) * 2;
        }


    }

    /// <summary>
    /// 正文形
    /// </summary>
    class ZFX : JX
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_BZ">边长</param>
        public ZFX(decimal _BZ) : base(_BZ, _BZ)
        {
        }
    }

    class YUAN : TX
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_BJ">半径</param>
        public YUAN(decimal _BJ)
        {
            BJ = _BJ;
            Pi = 3.141592M;
        }
        /// <summary>
        /// 半径
        /// </summary>
        public decimal BJ { get; set; }
        /// <summary>
        /// 派
        /// </summary>
        private decimal Pi { get; set; }

        /// <summary>
        /// 求面积
        /// </summary>
        /// <returns>返回面积</returns>
        public override decimal MJ()
        {
            return Pi * BJ * BJ;
        }


        /// <summary>
        /// 求周长
        /// </summary>
        /// <returns>返回周长</returns>
        public override decimal ZC()
        {
            return 2 * Pi * BJ;
        }
    }
    #endregion

    #region 动物题

    
    abstract class Animal
    {
        public abstract void Speak();
    }

    class Person : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("我是一个人");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("汪汪汪");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("喵喵喵");
        }
    }
    #endregion
}