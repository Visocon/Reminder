using System;
using Topshelf;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Remind>(s =>
                {
                    s.ConstructUsing(remind => new Remind());
                    s.WhenStarted(remind => remind.Start());
                    s.WhenStopped(remind => remind.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("Reminder");
                x.SetDisplayName("Reminder");
                x.SetDescription("Puts you in your place.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
