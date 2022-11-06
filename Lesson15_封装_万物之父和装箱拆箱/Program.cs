namespace Lesson15_封装_万物之父和装箱拆箱
{
    #region 知识点一 万物之父
    //万物之父
    //关键字：object
    //概念：
    //object是所有类型的基类，它是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有对象
    //2.可以用来表示不确定类型，作为函数参数类型
    #endregion


    class Father
    {
        public void Speak()
        {
            Console.WriteLine("FatherSpeak");
        }
    }

    class Son:Father
    {
        public new void Speak()
        {
            Console.WriteLine("SonSpeak");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson15_封装_万物之父和装箱拆箱");

            #region 知识点二 万物之父的使用
            Father f = new Son();
            if (f is Son)
            {
                (f as Son).Speak();
            }

            //引用类型
            object o=new Son();
            
            o = f;

            //用is as 来判断和转换即可
            if (o is Father)
            {
                (o as Father).Speak();
            }

            //值类型
            object o2 = 1;

            //用强转
            int i = (int)o2;

            //特殊的string类型
            object o3 = "aaa";

            
            Console.WriteLine(o3 as string);
            Console.WriteLine(o3.ToString());

            //数组
            object o4 = new int[10];
            int[] arr = o4 as int[];
            int[] arr2 = (int[])o4;


            //引用类型最好都用as
            #endregion


            #region 知识点三 装箱拆箱
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型（拆箱）

            //装箱
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中

            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中

            //好处：不确定类型时可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗

            //装箱
            object v = 3;
            //拆箱
            int v1 = (int)v;
            #endregion


        }

      
    }
}