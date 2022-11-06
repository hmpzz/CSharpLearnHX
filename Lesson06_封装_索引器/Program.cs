namespace Lesson06_封装_索引器
{

    #region 知识点一 索引器基本概念
    //基本概念
    //让对象可以像数组一样通过索引访问其中的元素，使程序看起来更直观，更容易编写
    #endregion

    #region 知识点二 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名......]
    //{
    //    内部的写法和规则和索引器相同
    //      get{}
    //      set{}
    //}

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private Person[] Friends;

        public Person this[int index]
        {
            get 
            {
                if (index >= this.Friends.Count())
                {
                    return null;
                }

                return Friends[index];
            }
            set
            {
                //value代表传入的值

                if (index >=this.Friends.Count())
                {
                    return;
                }
                Friends[index] = value;
            }
        }


        public Person()
        {
            Name = "";
            this.Friends =new Person[1];
        }

    }
    #endregion


    #region 知识点四 索引器中可以写逻辑

    #endregion

    #region 知识点五 索引器可以重载

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson06_封装_索引器");

            #region 知识点三 索引器的使用

            Person p=new Person();
            p[1]=new Person{ Name="friend01" , Age=20};

            #endregion

            Console.WriteLine(p[1].Name);
        }
    }
}