using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, n = 2;
            Console.Write("请输入一个数字：");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n = n / i;
                    Console.Write("{0}", "所有质数因子为" + i + " ");
                }
                else
                    ++i;

            }
        }
    }
}
