using System;

#region 知识点一 命名空间基本概念
//概念
//命名空间是用来组织和重用代码的
//作用
//就像是一个工具包，类就像是一件一件的工具，都是申明在命名空间中的
#endregion

#region 知识点二 命名空间的使用
//基本语法
//namespace 命名空间名
//{
//      类
//      类
//}

namespace Myname
{
    class GameObject
    {
    }
}

namespace Myname
{
    class Player : GameObject
    {
    }
}
#endregion

#region 知识点四 不同命名空间中允许有同名类

#endregion

#region 知识点五 命名空间可以包裹命名空间
namespace MyGame
{
    namespace UI
    {

    }
    namespace Game
    {

    }
}
#endregion

#region 知识点六 关于修饰类的访问修饰符
//public    —— 命名空间中的类 默认public
//internal  —— 只能在该程序集中使用
//abstract  —— 抽象类
//sealed    —— 密封类
//partial   —— 分部类
#endregion



namespace Lesson21_面向对象相关_命名空间
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");

            #region 知识点三 不同命名空间中相互使用 需要引用命名空间或指明出处

            Myname.GameObject gameObject = new Myname.GameObject();
            #endregion
        }
    }
}