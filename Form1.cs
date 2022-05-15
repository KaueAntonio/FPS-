using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Threading;
using Microsoft.Win32;
using System.Security;
using System.Runtime.InteropServices;

namespace mandrakespcfps
{


    
    public partial class comecar : Form
    {
        public comecar()
        {
            
            {
                manual _f2;
                _f2 = new manual();
                _f2.Show();
            }
               
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //processos cmd
            System.Diagnostics.Process.Start("cmd.exe", "/C \"C:\\windows\\SYSTEM32\\cleanmgr.exe\" /verylowdisk");
            System.Diagnostics.Process.Start("cmd.exe", "/C \"Defrag C: D: /TierOptimize /MultiThread:");
            System.Diagnostics.Process.Start("cmd.exe", "/C \"del /q/f/s %temp%\\*");
            System.Diagnostics.Process.Start("cmd.exe", "/C \"del /q/f/s C:\\Windows\\Prefetch\\*");      
           //processos powershell
            System.Diagnostics.Process.Start("powershell.exe", "/C \"powercfg /S 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
            //string caminho do registro.
            const string userRoot = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile";
            // Nome da instancia dps valor.
            Registry.SetValue(userRoot, "SystemResponsiveness", unchecked((int)00000000), RegistryValueKind.DWord);
            //string caminho do registro.
            const string userRoot1 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games";
            // Nome da instancia dps valor.
            Registry.SetValue(userRoot1, "GPU Priority", unchecked((int)00000008), RegistryValueKind.DWord);
            Registry.SetValue(userRoot1, "Priority", unchecked((int)00000006), RegistryValueKind.DWord);
            const string userRoot3 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games";
            Registry.SetValue(userRoot3, "Scheduling Category", "High", RegistryValueKind.String);
            Registry.SetValue(userRoot3, "SFIO Priority", "High", RegistryValueKind.String);
            const string userRoot2 = @"HKEY_CURRENT_USER\System\GameConfigStore";
            // Nome da instancia dps valor.
            Registry.SetValue(userRoot2, "GameDVR_FSEBehaviorMode", unchecked((int)00000002), RegistryValueKind.DWord);
            Registry.SetValue(userRoot2, "GameDVR_HonorUserFSEBehaviorMode", unchecked((int)00000001), RegistryValueKind.DWord);
            Registry.SetValue(userRoot2, "GameDVR_FSEBehavior", unchecked((int)00000002), RegistryValueKind.DWord);
            Registry.SetValue(userRoot2, "GameDVR_DXGIHonorFSEWindowsCompatible", unchecked((int)00000001), RegistryValueKind.DWord);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
