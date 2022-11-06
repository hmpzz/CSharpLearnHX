namespace Lesson18_多态_抽象类和抽象方法
{
    internal class Program
    {

        #region 知识点一 抽象类
        //概念
        //被抽象关键字abstract修饰的类
        //特点：
        //1.不能被实例化的类
        //2.可以包含抽象方法
        //3.继承抽象类必须重写其抽象方法

        abstract class Thing
        { 
            //抽象类中 封闭的所有知识点都可以在其中书写
            public string Name { get; set; }

            //可以在抽象类中写抽象方法

        }

        class Water : Thing
        { 

        }
        #endregion

        #region 知识点二 抽象函数
        //又叫 纯虚方法
        //用abstract关键字修饰的方法
        //特点：
        //1.只能在抽象类中申明
        //2.没有方法体
        //3.不能是私有的
        //4.继承后必须实现 用override重写

        abstract class Fruits
        {


            public Fruits()
            {
                Name = "";
            }
            public virtual string Name { get; set; }

            //抽象方法 一定不能有函数体的（没有大括号）
            public abstract void Bad();
        }

        class Apple:Fruits
        {
            public Apple()
            {
                _Name = "苹果";
            }


            private string _Name;
            public override string Name {
                get
                {
                    return _Name;
                } 
            }
            public override void Bad()
            {
                Console.WriteLine($@"{Name}坏掉了");
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法");

            //抽象类不能被实例化
            //Thing t = new Thing();

            //但可以用父类容器装子类
            Thing t = new Water();

            Fruits fruits = new Apple();
            fruits.Bad();
             
        }
    }


    //总结
    //如何选择普通类还是抽象类
    //不希望被实例化的对象，相对比较抽象的类可以使用抽象类，如Frutis,Thing
    //父类中的行为不丈需要被实现的，只希望子类去定义具体规则的 可以选择 抽象类然后使用其中的抽象方法来定义规则 
    //作用
    //整体框架设计时 会使用
}