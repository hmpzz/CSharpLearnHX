namespace Lesson13_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson13_练习");

            List<Monster> monsters=new List<Monster>();
            //随机生成10个怪，3成机率是BOSS
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                if (rd.Next(0,10)>7)
                {
                    monsters.Add(new Boss());
                }
                else
                {
                    monsters.Add(new Goblin());
                }
            }

            foreach (Monster monster in monsters)
            {
                if (monster is Boss)
                {
                    (monster as Boss).BossAtk();
                }
                else if (monster is Goblin)
                {
                    (monster as Goblin).GoblinAtk();
                }
            }


        }
        private class Monster
        {

        }

        private class Boss : Monster
        {
            public void BossAtk()
            {
                Console.WriteLine("BOSS放大招了！！！");
            }
        }

        private class Goblin : Monster
        {
            public void GoblinAtk()
            {
                Console.WriteLine("Goblin砍了一刀。");
            }
        }
    }

    
}