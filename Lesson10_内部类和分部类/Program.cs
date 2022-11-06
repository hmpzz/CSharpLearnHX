namespace Lesson11_内部类和分部类
{
    #region 分部类
    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //作用
    //分部描述一个类
    //增加程序的拓展性

    //注意
    //分部类可以写在多个脚本文件中
    //分部类的访问修饰符要一致
    //分部类中不能有重复成员 

    partial class Student
    {
        public bool Sex { get; set; }
        public int Name;
    }
    partial class Studen
    {
        public int Number;
        public void Speak(string str)
        { 
        }
    }

    #endregion

     #region 分部方法
    //概念
    //将方法的申明和实现分离
    //特点
    //1.不能加访问修饰符 默认私在
    //2.只能在分部类中申明
    //3.返回值只能是void
    //4.可以有参数但不用 out关键字


    //鸡肋

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分部类");


        }
    }
}