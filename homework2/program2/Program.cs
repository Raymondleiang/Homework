using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 2, 4, 5, 6, 55, 66, 89, 105, 669, 569 };
            ArrayList list = new ArrayList(arr);
            list.Sort();
            int min = Convert.ToInt32(list[0]);
            int max = Convert.ToInt32(list[list.Count - 1]);
            Console.WriteLine("最大" + max + " 最小:" + min);
            int average = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                average += arr[j];
            }
            Console.WriteLine("平均数为" + average / 10);
            Console.WriteLine("和为" + average);
        }
    }
}
