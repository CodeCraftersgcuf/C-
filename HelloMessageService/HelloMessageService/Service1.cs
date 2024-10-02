using System;
using System.IO;
using System.IO.Pipes;
using System.ServiceProcess;
using System.Timers;

namespace HelloMessageService
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer;
        private int executionCount = 0;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer(5000); // Set the interval to 5 seconds
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            executionCount++;

            // Send a message to the WinForms app through Named Pipes
            SendMessageToClient($"Hello, World! - Execution {executionCount}");

            if (executionCount >= 5)
            {
                Stop(); // Stop the service after 5 executions
            }
        }

        private void SendMessageToClient(string message)
        {
            try
            {
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("HelloMessagePipe"))
                {
                    pipeServer.WaitForConnection();

                    using (StreamWriter writer = new StreamWriter(pipeServer))
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine(message); // Send the message to the client
                    }
                }
            }
            catch (Exception ex)
            {
                // Log any errors in the event log
                EventLog.WriteEntry("Error sending message: " + ex.Message);
            }
        }

        protected override void OnStop()
        {
            // Clean up the timer
            timer?.Stop();
        }
    }
}
