namespace Lesson19_多态_接口
{

    #region 知识点一 接口的概念
    //接口是行为的抽象规范
    //它也是一种自定义类型
    //关键字：interface

    //接口申明的规范
    //1.不包含成员变量
    //2.只包含方法、属性、索引器、事件
    //3.成员不能被实现
    //4.成员可以不用写访问修饰符，不能是私有的
    //5.接口不能继承类，但是可以继承另一个接口

    //接口的使用规范
    //1.类可以继承多个接口
    //2.类继承接口后，必须实现接口中所有成员

    //特点：
    //1.它和类的申明类似
    //2.接口是用来继承的
    //3.接口不能被实例化，但是可以作为容器 存储对象
    #endregion

    #region 知识点二 接口的申明
    //接口关键字：interface
    //语法：
    //interface 接口名
    //{
    //}
    //一句话记忆：接口是抽象行为的“基类”
    //接口命名规范 帕斯卡前面加个I

    interface IFly
    {
        //成员变量，这样写会报错是，接口中是不能有这玩意的
        //int a;

        //属性 可以有，没问题(不能有实现)
        public int Name { get; set; }

        //方法 可以有
        void Fly();

        //索引器
        int this[int index] { get;set; }

        //事件
        event Action doSomeThing;
    }
    #endregion

    #region 知识点三 接口的使用
    //接口用来继承

    //1.类可以继承1个类,n个接口
    //2.继承了接口后 必须实现其中的内容 并且必须是public的
    //3.实现的接口函数，可以加V再在子类重写
    //4.接口也遵循里氏替换原则


    class Animal
    {

    }

    class Person : Animal, IFly
    {
        public int this[int index]
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public int Name { get ; set ; }

        public event Action doSomeThing;

        public void Fly()
        {
            Console.WriteLine("飞飞飞");
        }
    }

    #endregion

    #region 知识点四 接口可以继承
    //接口继承接口时 不需要实现
    //待类继承接口后 类自己去实现所有内容

    interface IWalk
    { 
        void Walk();
    }

    interface IMove : IFly, IWalk
    { 
    }

    class Test : IMove
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action doSomeThing;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region 知识点五 显示实现接口
    //当一个类继承两个接口
    //但是接口中存在着同名方法时
    //注意：显示实现接口时 不能写访问修饰符

    interface IAtk
    { 
        void Atk();
    }
    interface ISuperAtk
    {
        void Atk();
    }

    class Player : IAtk, ISuperAtk
    {
        //显示实现接口 就是用 接口名.行为名 去实现
        void IAtk.Atk()
        {
            Console.WriteLine("IATK.ATK");
        }

        void ISuperAtk.Atk()
        {
            Console.WriteLine("ISuperATK.ATK");
        }

        public void Atk()
        {
            Console.WriteLine("Player.ATK");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lesson19_多态_接口");

            IMove im = new Test();
            IFly iFly = new Test();
            IWalk iWalk = new Test();

            IAtk iA = new Player();
            ISuperAtk iSA = new Player();

            iA.Atk();
            iSA.Atk();

            Player p = new Player();
            (p as IAtk).Atk();
            (p as ISuperAtk).Atk();
            p.Atk();

            #region 用接口装载不同类对象

            IFlyTest bird = new Bird();
            IFlyTest plane = new Plane();

            bird.Fly();
            plane.Fly();

            (bird as Bird).Speak();
            #endregion

        }
    }

    //总结：
    //继承类：是对象间的继承，包括特征行为等等
    //继承接口：是行为间的继承，继承接口的行为规范，按照规范去实现内容
    //由于接口也是遵循里氏替换原则，所以可以用接口对象装对象
    //那么就可以实现 装载各种毫无关系但是去有相同行为的对象（比如动物类下面的鸟类可以继承飞的接口，机器类下面的飞机类也可以继承飞的接口，那么飞接口对象就可以装载不同类【鸟类】与【飞机类】的对象）

    #region 用接口装载不同类对象

    
    class AnimalTest
    { 
    }

    
    interface IFlyTest
    {
        void Fly();
    }

    class Bird : AnimalTest, IFlyTest
    {
        public void Fly()
        {
            Console.WriteLine("小鸟飞");
        }

        public void Speak()
        {
            Console.WriteLine("小鸟叫");
        }
    }

    class Machine
    { 
    }

    class Plane : Machine, IFlyTest
    {
        public void Fly()
        {
            Console.WriteLine("飞机飞");
        }
    }
    #endregion
    //注意：
    //1.接口只包含 成员方法、属性、索引器、事件，并且都不实现，都没访问修饰符
    //2.可以继承多个接口，但是只能继承一个类
    //3.接口可以继承接口，相当于在进行行为合并，待子类继承时再去实现具体的行为
    //4.接口可以被显示实现 主要是用于实现不同接口中的同名函数的不同表现
    //5.实现的接口方法 可以加 virtual关键字 之后子类再重写
}