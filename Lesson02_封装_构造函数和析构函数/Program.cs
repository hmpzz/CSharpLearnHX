namespace Lesson04_封装_构造函数和析构函数
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数");


            Person p1 = new Person("张三", 18);

            p1.Friends = new List<Person> { new Person("李四", 19), new Person("王五", 20) };

            Console.WriteLine(p1[1].Name);

        }

        /// <summary>
        /// 定义人类
        /// </summary>
        class Person
        {

            public Person():this("aaa",18)
            {
                //Name = "aaa";
                //Age = 18;
            }

            public Person(int _age)
            { 
                Age = _age;
            }

            public Person(string _name)
            {
                Name = _name;
            }
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="_name">姓名</param>
            /// <param name="_age">年龄</param>
            public Person(string _name , int _age ):this(18)
            {
                this.Name = _name;
                this.Age = _age;

            }
            public string? Name { get; set; }
            public int Age { get; set; }

            public List<Person> Friends;

            public Person this[int index]
            {
                get
                {
                    return Friends[index];
                }
                set { }
            }

            public string aa
            { 
                get { return this.aa.ToString().ToUpper(); }
                set { this.aa = value.ToUpper(); }
            }
        }
    }
}