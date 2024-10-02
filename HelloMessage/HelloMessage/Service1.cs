using System;
using System.IO;
using System.IO.Pipes;
using System.ServiceProcess;
using System.Timers;

namespace HelloMessage
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
            // Setup a timer to trigger the message every 5 seconds
            timer = new Timer(5000); // 5 seconds interval
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            executionCount++;

            // Send a message to the client to display a dialog
            SendMessageToClient($"Hello, World! - Execution {executionCount}");

            if (executionCount >= 5)
            {
                Stop(); // Stop after 5 executions
            }
        }

        private void SendMessageToClient(string message)
        {
            try
            {
                // Named Pipe communication to the client app
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("HelloMessagePipe"))
                {
                    pipeServer.WaitForConnection();

                    using (StreamWriter writer = new StreamWriter(pipeServer))
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine(message); // Send message to the client
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error to the Event Log
                EventLog.WriteEntry("Error sending message to client: " + ex.Message);
            }
        }

        protected override void OnStop()
        {
            // Clean up the timer when the service stops
            timer?.Stop();
        }
    }
}
