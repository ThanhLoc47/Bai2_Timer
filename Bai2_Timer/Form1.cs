using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Bai2_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string flags, time, oldtime;

        private void btnAbort_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            toolStripStatusLabel1.Text = "Task Aborted";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oldtime = time;
            time = (Convert.ToInt32(time) - 1).ToString();
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Replace(oldtime, time);
            if (time == "0") { Shutdown(); timer1.Stop(); }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            time = txtShutdown.Text;
            switch (cbbTask.SelectedIndex)
            {
                case 0: { flags = "0"; toolStripStatusLabel1.Text = "Windows will shut down in " + time + " seconds!"; } break;
                case 1: { flags = "1"; toolStripStatusLabel1.Text = "Windows will restart in " + time + " seconds!"; } break;
                case 2: { flags = "2"; toolStripStatusLabel1.Text = "Windows will log off in " + time + " seconds!"; } break;
            }
            timer1.Start();
        }

        public void Shutdown()
        {
            ManagementBaseObject shutdown = null;
            ManagementClass win32 = new ManagementClass("Win32_OperatingSystem");
            win32.Get();
            win32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject shutdownparam = win32.GetMethodParameters("Win32Shutdown");
            shutdownparam["Flags"] = flags;
            shutdownparam["Reserved"] = "0";
            foreach (ManagementObject mObj in win32.GetInstances())
            {
                shutdown = mObj.InvokeMethod("Win32Shutdown", shutdownparam, null);
            }
        }
    }
}
