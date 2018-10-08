using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class Time
    {
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }
    }

    public delegate void RemindClock(object sender, Time t);

    public class Clock
    {
        public event RemindClock Alarm;
        public void DoClock(int t)
        {
            Thread.Sleep(1000 * t);
            Time time = new Time
            {
                Hour = DateTime.Now.Hour,
                Minute = DateTime.Now.Minute,
                Second = DateTime.Now.Second
            };

            Alarm(this, time);
        }

    }
    class AlarmClock
    {
        static void Main(string[] args)
        {
            string nowTime = DateTime.Now.ToLongTimeString();
            Console.WriteLine("当前时间是：" + nowTime);

            Console.WriteLine("您想上多久的闹钟:");
            int After = int.Parse(Console.ReadLine());
            var clock = new Clock();
            clock.Alarm += show;
            clock.DoClock(After);
        }
        static void show(object sender, Time time)
        {
            Console.Write("Now the time is:");
            showTime(time);
            Console.WriteLine("Time up");
        }
        static void showTime(Time e)
        {
            Console.WriteLine(e.Hour + ":" + e.Minute + ":" + e.Second);
        }
    }
}
