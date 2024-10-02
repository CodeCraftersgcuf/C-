using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer = new Timer();
        private readonly object lockObject = new object();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += OnElapsedTime;
            timer.Interval = 5000; // 5 seconds
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            timer.Enabled = false; // Disable the timer
            timer.Dispose(); // Dispose of the timer
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile("Service is recalled at " + DateTime.Now);
        }

        public void WriteToFile(string message)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = Path.Combine(path, "ServiceLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt");

            try
            {
                lock (lockObject)
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log to Event Viewer)
            }
        }
    }
}
