namespace Lesson19_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson19_练习");

            #region 登记题

            IDJ person = new Person();
            IDJ car = new Car();
            IDJ house = new House();

            person.DJ();
            car.DJ();
            house.DJ();

            #endregion

            Console.WriteLine("########################");

            #region 一堆动物和直升飞机的题

            IFly mQ = new MQ();
            IFly yW = new YW();
            IFly helicopter = new Helicopter();
            IFly tE = new TE();

            mQ.Fly();
            yW.Fly();
            helicopter.Fly();
            tE.Fly();

            ISwim qES = new QE();
            ISwim tES = new TE();

            qES.Swim();
            tES.Swim();

            IWalk mQW = new MQ();
            IWalk tNW = new TN();
            IWalk qEW = new QE();
            IWalk yWW = new YW();
            IWalk tEW = new TE();

            mQW.Walk();
            tNW.Walk();
            qEW.Walk();
            yWW.Walk();
            tEW.Walk();

            #endregion

            Console.WriteLine("########################");

            #region 电脑读取数据的题

            Computer computer = new Computer();

            ICCSB movdHardDisk = new MovdHardDisk();
            ICCSB uDisk = new UDisk();

            IBFSB mp3 = new MP3();

            computer.CR(movdHardDisk );
            computer.Read();
            computer.Write();
            computer.Play();

            computer.CR(uDisk);
            computer.Read();
            computer.Write();
            computer.Play();


            computer.CR(mp3);
            computer.Read();
            computer.Write();
            computer.Play();

            #endregion
        }
    }

    #region 登记题
    /// <summary>
    /// 登记接口
    /// </summary>
    interface IDJ
    {
        /// <summary>
        /// 登记方法
        /// </summary>
        void DJ();
    }

    /// <summary>
    /// 人类
    /// </summary>
    class Person : IDJ
    {
        public void DJ()
        {
            Console.WriteLine("人类的登记方法");
        }
    }

    /// <summary>
    /// 车类
    /// </summary>
    class Car : IDJ
    {
        public void DJ()
        {
            Console.WriteLine("车的登记方法");
        }
    }

    /// <summary>
    /// 房子类
    /// </summary>
    class House : IDJ
    {
        public void DJ()
        {
            Console.WriteLine("房子的登记方法");
        }
    }
    #endregion

    #region 一堆动物和直升机的题

    /// <summary>
    /// 飞的接口
    /// </summary>
    interface IFly
    {
        /// <summary>
        /// 飞的方法
        /// </summary>
        void Fly();
    }

    /// <summary>
    /// 走的接口
    /// </summary>
    interface IWalk
    {
        /// <summary>
        /// 走的方法
        /// </summary>
        void Walk();
    }

    /// <summary>
    /// 游泳的接口
    /// </summary>
    interface ISwim
    {
        /// <summary>
        /// 游泳的方法
        /// </summary>
        void Swim();
    }

    /// <summary>
    /// 麻雀类（只能飞和走）
    /// </summary>
    class MQ : IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("麻雀飞");
        }

        public void Walk()
        {
            Console.WriteLine("麻雀走");
        }
    }

    /// <summary>
    /// 驼鸟类（只能走）
    /// </summary>
    class TN : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("驼鸟走");
        }
    }

    /// <summary>
    /// 企鹅类（能走能游泳）
    /// </summary>
    class QE : IWalk, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("企鹅游泳");
        }

        public void Walk()
        {
            Console.WriteLine("企鹅走");
        }
    }

    /// <summary>
    /// 鹦鹉类（能飞能走）
    /// </summary>
    class YW : IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉飞");
        }

        public void Walk()
        {
            Console.WriteLine("鹦鹉走");
        }
    }

    /// <summary>
    /// 直升飞机类（只能飞）
    /// </summary>
    class Helicopter : IFly
    {
        public void Fly()
        {
            Console.WriteLine("直升飞机飞");
        }
    }

    /// <summary>
    /// 天鹅类（能飞能走能游泳）
    /// </summary>
    class TE : IFly, IWalk, ISwim
    {
        public void Fly()
        {
            Console.WriteLine("天鹅飞");
        }

        public void Swim()
        {
            Console.WriteLine("天鹅游泳");
        }

        public void Walk()
        {
            Console.WriteLine("天鹅走");
        }
    }
    #endregion

    #region 电脑读取数据的题

    /// <summary>
    /// 存储设备类
    /// </summary>
    interface ICCSB:IUSB
    {
       

    }

    /// <summary>
    /// 播放设备类
    /// </summary>
    interface IBFSB: ICCSB
    {
        /// <summary>
        /// 播放类
        /// </summary>
        void Play();
    }

    interface IUSB 
    {
        /// <summary>
        /// 读方法
        /// </summary>
        void Read();
        /// <summary>
        /// 写方法
        /// </summary>
        void Write();

      
    }
    /// <summary>
    /// 计算机类
    /// </summary>
    class Computer //: IUSB
    {

        public Computer()
        {
            uSB = null;
        }

        private IUSB? uSB { get; set; }

        public void CR(IUSB _USB)
        {
            uSB = _USB;
        }

        public void Play()
        {
            if (uSB is null)
            {
                Console.WriteLine("设有插入设备！");
            }
            else if ((uSB is IBFSB))
            {
                (uSB as IBFSB).Play();
            }
            else
            {
                Console.WriteLine("此设备不是播放设备，不能播放！");
            }
        }

        public void Read()
        {
            if (uSB is null)
            {
                Console.WriteLine("设有插入设备！");
            }
            else if ((uSB is ICCSB))
            {
                uSB.Read();
            }

        }

        public void Write()
        {
            if (uSB is null)
            {
                Console.WriteLine("设有插入设备！");
            }
            else if ((uSB is ICCSB))
            {
                uSB.Write();
            }
        }
    }

    /// <summary>
    /// 移动硬盘类
    /// </summary>
    class MovdHardDisk : ICCSB
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            Console.WriteLine("移动硬盘，读数据！");
        }

        public void Write()
        {
            Console.WriteLine("移动硬盘，写数据！");
        }
    }

    /// <summary>
    /// U盘类
    /// </summary>
    class UDisk : ICCSB
    {
        public void Read()
        {
            Console.WriteLine("U盘，读数据！");
        }

        public void Write()
        {
            Console.WriteLine("U盘，写数据！");
        }
    }

    /// <summary>
    /// MP3类
    /// </summary>
    class MP3 : IBFSB
    {
        public void Play()
        {
            Console.WriteLine("MP3播放！！");
        }

        public void Read()
        {
            Console.WriteLine("MP3，读数据！");
        }

        public void Write()
        {
            Console.WriteLine("MP3，写数据！");
        }
    }
    #endregion
}