namespace Lesson20_多态_密封方法
{
    internal class Program
    {

        #region 知识点一 密封方法基本概念
        //用密封关键字sealed 修饰的重写函数
        //作用：让虚方法或者抽象方法之后不能再被重写
        //特点：和override一起出现
        #endregion

        #region 知识点二 实例
        abstract class Animal
        { 
            public string Name { get; set; }
            public abstract void Eat();

            public virtual void Speak()
            {
                Console.WriteLine("叫");
            }
        }
        class Person : Animal
        {
            public sealed override void Eat()
            {
                Console.WriteLine("人吃");
            }

            public override void Speak()
            {
                Console.WriteLine("喊");
            }
        }

        class WritePerson: Person
        {
            public  void Eat()
            {
                Console.WriteLine("白人吃");
            }

            public override void Speak()
            {
                Console.WriteLine("白人喊");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("密封方法");


            Animal person = new Person();
            person.Eat();
            Animal writePerson = new WritePerson();
            writePerson.Eat();
            (writePerson as WritePerson).Eat();
        }

        
    }
}