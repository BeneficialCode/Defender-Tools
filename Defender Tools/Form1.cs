using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Defender_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.button1.Enabled = false;
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", 1);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableIOAVProtection", 1);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", 1);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", 1);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", "Start", 4);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", "Start", 4);
                base.Hide();
                MessageBox.Show("关闭Windows Defender成功，重启计算机后生效", "提示");
                base.Close();
                this.button1.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("出现了一些问题~"+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.button2.Enabled = false;
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 0);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", 0);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableIOAVProtection", 0);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", 0);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", 0);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", "Start", 2);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", "Start", 2);

                base.Hide();
                MessageBox.Show("开启Windows Defender成功，重启计算机后生效", "提示");
                base.Close();
                this.button2.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("出现了一些问题~"+ex.Message, "提示");
                this.button2.Enabled = true;
            }
        }
    }
}
