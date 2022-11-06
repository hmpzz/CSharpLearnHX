namespace Lesson14_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CXY cXY = new CXY();
            CH cH = new CH();
            MS mS = new MS();

            cXY.GZFF();
            cH.GZFF();
            mS.GZFF();
        }
    }

    /// <summary>
    /// 打工人类
    /// </summary>
    class DGR
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_GZ">工种</param>
        /// <param name="_GZNR">工作内容</param>
        public DGR(string _GZ, string _GZNR)
        {
            GZ = _GZ;
            GZNR = _GZNR;
        }
        /// <summary>
        /// 工种
        /// </summary>
        public string GZ { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        public string GZNR { get; set; }

        /// <summary>
        /// 工作方法
        /// </summary>
        public void GZFF()
        {
            Console.WriteLine($@"{GZ}的工作内容是{GZNR}！");
        }
    }
    /// <summary>
    /// 程序员类
    /// </summary>
    class CXY : DGR
    {
        public CXY(string _GZ = "程序员", string _GZNR = "写代码") : base(_GZ, _GZNR)
        {
        }
    }
    /// <summary>
    /// 策划类
    /// </summary>
    class CH : DGR
    {
        public CH(string _GZ = "策划", string _GZNR = "瞎策划") : base(_GZ, _GZNR)
        {
        }
    }
    /// <summary>
    /// 美术类
    /// </summary>
    class MS : DGR
    {
        public MS(string _GZ = "美术", string _GZNR = "画画") : base(_GZ, _GZNR)
        {
        }
    }
}