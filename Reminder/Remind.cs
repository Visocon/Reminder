using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.IO;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Reminder
{
    public class Remind
    {
        private readonly Timer _timer;

        public Remind()
        {
            _timer = new Timer(5000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Random rand = new Random();

            switch (rand.Next(1, 7))
            {
                case 1:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Cunt")
                        .AddText("Hey, you, you a bitch")
                        .Show();
                    break;

                case 2:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Hoe")
                        .AddText("Go suck a dick, you whore")
                        .Show();
                    break;

                case 3:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("I would love you...")
                        .AddText("But you just make me sad.")
                        .Show();
                    break;

                case 4:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Worthless.")
                        .AddText("That's what you are, WORTHLESS.")
                        .Show();
                    break;

                case 5:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Faggot")
                        .AddText("Loser, I bet you kiss men, faggot.")
                        .Show();
                    break;

                case 6:
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("You weeb")
                        .AddText("Stop watching the hentai you loser.")
                        .Show();
                    break;
            }

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
