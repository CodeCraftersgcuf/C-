using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;
namespace HelloMessageService
{
    partial class ProjectInstaller
    {
        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;

        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();

            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;

            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.ServiceName = "HelloMessageService";
            this.serviceInstaller1.Description = "A service that triggers a message to a WinForms app.";
            this.serviceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Manual;

            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            this.serviceInstaller1});
        }
    }
}
