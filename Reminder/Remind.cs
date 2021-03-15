using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.IO;

namespace Reminder
{
    public class Remind
    {
        private readonly Timer _timer;

        public Remind()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.Beep();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
