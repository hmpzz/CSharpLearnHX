using System.Security.Cryptography.X509Certificates;

namespace Lesson13_继承_里氏替换原则
{

    #region 基本概念
    //里氏替换原则是面向对象七大原则中最重要的原则
    //概念：
    //任何父类出现的地方，子类都可以替代
    //重点：
    //语法表现——父类窗口装子类对象，因为子类对象包含了父类的所有内容
    //作用：
    //方便进行对象存储和管理

    #endregion

    #region 基本实现
    class GameObject
    {

    }
    class Player : GameObject
    {
        public void PlayerAtk()
        {
            Console.WriteLine("玩家攻击");
        }
    }

    class Monster : GameObject
    {

        //public int k { get; set; }
        public void MonsterAtk()
        {
            Console.WriteLine("怪物攻击");
        }
    }

    class Boss : GameObject
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则");

            //里氏替换原则 用父类窗口装载子类对象
            GameObject player = new Player();
            GameObject monster = new Monster();
            GameObject boss = new Boss();

            GameObject[] objects=new GameObject[] { new Player(),new Monster(),new Boss()};


            #region is和as
            //基本概念
            //is:判断一个对象是否是执行类对象
            //返回值：bool 是为真 不是为假


            //as：将一个对象转换为指定的类对象
            //返回值：指定类型对象
            //成功返回执行类型对象，失败返回null



            //基本语法
            //类对象 is 类名   该语句块会有一个bool返回值 true或false
            //类对象 as 类名   该语句块会有一个对象返回值 对象或null


            if (monster is Player)
            {
                Player p = player as Player;
                p.PlayerAtk();
            }
            else if (monster is Monster)
            {
                Monster p = monster as Monster;
                p.MonsterAtk();

                //p.k = 100;

                //object oo = p;

                //if (oo is Monster)
                //{

                //    Console.WriteLine(oo.GetType().ToString());
                //    Console.WriteLine(player.GetType().ToString());
                //    Console.WriteLine((oo as Monster).k);
                //}
            }


            #endregion
        }
    }
}