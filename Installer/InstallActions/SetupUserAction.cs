using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Diagnostics;


namespace InstallActions
{
    [RunInstaller(true)]
    public partial class SetupUserAction : System.Configuration.Install.Installer
    {
        public SetupUserAction()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            //The following code will run our command file
            string targetFolder = this.Context.Parameters["instLoc"];
            Process myProcess = new Process();

            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = "/c \""+targetFolder+"Setup.cmd\"";
            
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.Start();
            
        }

    }
}
