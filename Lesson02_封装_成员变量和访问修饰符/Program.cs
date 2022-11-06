namespace Lesson02_封装_成员变量和访问修饰符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 10;
            Person p2 = p1;
            p2.Age = 20;


            Person c1=new Person();
            c1.ClassMate = new Person();
            c1.ClassMate.Age = 100;

            Person c2 = c1.ClassMate;
            c2.Age = 60;

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int Age { get; set; }
        public Person ClassMate { get; set; }
    }

}