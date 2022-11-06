using System.Net;

namespace Lesson17_多态_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson17_多态_练习");

            #region 鸭子题
            YZ yZ = new YZ();
            yZ.Speak();

            YZ myZ = new MYZ();    
            myZ.Speak();

            YZ pyZ = new PYZ();
            pyZ.Speak();
            #endregion 鸭子题

            #region 员工题

            YG yG = new YG();
            yG.DK();

            YG jL =new JL();
            jL.DK();

            YG cXY =new CXY();
            cXY.DK();

            #endregion

            #region 图形题

            TX jX = new JX(10,12);
            Console.WriteLine(jX.MJ());
            Console.WriteLine(jX.ZC());

            TX zFX = new ZFX(10);
            Console.WriteLine( zFX.MJ());
            Console.WriteLine(zFX.ZC());


            TX yUAN = new YUAN(10);
            Console.WriteLine(yUAN.MJ());
            Console.WriteLine(yUAN.ZC());


            #endregion
        }


        #region 鸭子题


        /// <summary>
        /// 鸭子类
        /// </summary>
        class YZ
        {
             public virtual void Speak()
            {
                Console.WriteLine("嘎嘎叫");
            }
        }

        /// <summary>
        /// 木鸭子类
        /// </summary>
        class MYZ : YZ
        {
            public override void Speak()
            {
                Console.WriteLine("吱吱叫");
            }
        }

        /// <summary>
        /// 皮鸭子类
        /// </summary>
        class PYZ : YZ
        {
            public override void Speak()
            {
                Console.WriteLine("唧唧叫");
            }
        }
        #endregion

        #region 员工题
        /// <summary>
        /// 员工类
        /// </summary>
        class YG
        {
            public virtual void DK()
            {
                Console.WriteLine("九点打卡");
            }
        }


        /// <summary>
        /// 经理类
        /// </summary>
        class JL:YG
        {
            public override void DK()
            {
                Console.WriteLine("十一点打卡");
            }
        }


        /// <summary>
        /// 程序员类
        /// </summary>
        class CXY : JL
        {
            public override void DK()
            {
                Console.WriteLine("爷不打卡");
            }
        }
        #endregion


        #region 图形题
        /// <summary>
        /// 图形类
        /// </summary>
        class TX
        {
            /// <summary>
            /// 面积方法
            /// </summary>
            /// <returns>返回求得的面积</returns>
            public virtual decimal MJ()
            {
                return 0;
            }
            /// <summary>
            /// 周长方法
            /// </summary>
            /// <returns>返回求得的周长</returns>
            public virtual decimal ZC()
            {
                return 0;
            }
        }

        /// <summary>
        /// 矩形类
        /// </summary>
        class JX :TX
        {

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="_Width">宽</param>
            /// <param name="_Height">高</param>
            public JX(decimal _Width,decimal _Height)
            {
                Width = _Width;
                Heigth = _Height;
            }
            /// <summary>
            /// 宽
            /// </summary>
            public decimal Width { get; set; }

            /// <summary>
            /// 高
            /// </summary>
            public decimal Heigth { get; set; }

            /// <summary>
            /// 求面积
            /// </summary>
            /// <returns>返回面积值</returns>
            public override decimal MJ()
            {
                return Width * Heigth;
            }
            /// <summary>
            /// 求周长
            /// </summary>
            /// <returns>返回周长</returns>
            public override decimal ZC()
            {
                return (Width + Heigth) * 2;
            }


        }

        /// <summary>
        /// 正文形
        /// </summary>
        class ZFX : JX
        {
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="_BZ">边长</param>
            public ZFX(decimal _BZ) : base(_BZ, _BZ)
            { 
            }
        }

        class YUAN : TX
        {
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="_BJ">半径</param>
            public YUAN( decimal _BJ)
            { 
                BJ= _BJ;
                Pi=3.141592M;
            }
            /// <summary>
            /// 半径
            /// </summary>
            public decimal BJ { get; set; }
            /// <summary>
            /// 派
            /// </summary>
            private decimal Pi { get; set; }

            /// <summary>
            /// 求面积
            /// </summary>
            /// <returns>返回面积</returns>
            public override decimal MJ()
            {
                return Pi * BJ * BJ;
            }


            /// <summary>
            /// 求周长
            /// </summary>
            /// <returns>返回周长</returns>
            public override decimal ZC()
            {
                return 2 * Pi * BJ;
            }
        }
        #endregion
    }
}