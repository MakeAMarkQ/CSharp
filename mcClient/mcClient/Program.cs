using System;
using mcMath;

namespace mcClient
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            mcMathComp cls = new mcMathComp();
            long lRes = cls.Add(23, 40);
            cls.Extra = false;
            Console.WriteLine(lRes.ToString());
            Console.ReadKey();
        }
    }
}
