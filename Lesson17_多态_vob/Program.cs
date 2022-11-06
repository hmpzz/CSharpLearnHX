 namespace Lesson17_多态_vob
{

    #region 知识点一 多态的概念
    //多态按字面的意思就是“多种状态”
    //让继承同一父类的子类们 在执行相同方法时有不同的表现（状态）
    //主要目的
    //同一父类的对象 执行相同行为（方法）有不同的表现
    //解决的问题
    //让同一个对象有唯一行为的特征
    #endregion

    #region 知识点二 解决的问题
    class Father
    { 
        public void SpeakName()
        {
            Console.WriteLine("Father的方法");
        }

    }

    class Son:Father
    {
        public new void SpeakName()
        {
            Console.WriteLine("Son的方法");
        }
    }
    #endregion

    #region 知识点三 多态的实现
    //我们目前已经学过的多态
    //编译时多态——函数重载，开始就写好的

    //我们将学习的：
    //运行时多态（vob、抽象函数、接口）
    //我们今天学习vob
    //v：virtual(虚函数)
    //o：override(重写)
    //b：base(父类)

    class GameObject
    {
        public GameObject(string _Name)
        {
            this.Name = _Name;
        }

        public string Name { get; set; }

        //虚函数可以被子类重写
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象进行攻击");
        }

        public void Speak()
        {
            Console.WriteLine("哈哈哈");
        }
    }

    class Player : GameObject
    {
        public Player(string _Name) : base(_Name)
        {
        }

        //重写虚函数
        public override void Atk()
        {
            //base作用
            //代表父类 可以通过base保留父类的行为
            //base.Atk();

            Console.WriteLine("玩家对象进行攻击");
        }

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson17_多态_vob");

            #region 解决的问题
            Father f=new Son();
            f.SpeakName();

            (f as Son).SpeakName();
            #endregion

            #region 多态的使用
            //如果用了vob 那么new什么对象(new的Son对象)就会执行什么对象的方法
            //如果不用vob 那么会就像上面一样，定义的什么对象(上面字义的是Father)就执行什么对象的方法
            GameObject  p = new Player("唐老师");
            p.Atk();
            p.Speak();

            #endregion
        }
    }
}