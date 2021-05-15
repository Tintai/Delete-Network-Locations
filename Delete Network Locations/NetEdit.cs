using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
namespace Delete_Network_Locations
{
    public partial class NetEdit : Form
    {
        string profiles = "Software\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles";
        string signatures = "Software\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Signatures";
        public NetEdit()
        {
            InitializeComponent();
        }
        private void NetworkLocations()
        {
            listView_networks.Items.Clear();
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(profiles))
                {
                    foreach (string subKeyName in key.GetSubKeyNames())
                    {
                        using (RegistryKey tempKey = key.OpenSubKey(subKeyName))
                        {
                            listView_networks.Items.Add(tempKey.GetValue("ProfileName").ToString()).SubItems.Add(subKeyName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error code:\n" + ex.ToString(), "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void NetEdit_Load(object sender, EventArgs e)
        {
            NetworkLocations();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string netremv = null;
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(profiles, true))
                {
                    foreach (ListViewItem eachItem in listView_networks.SelectedItems)
                    {
                        netremv = listView_networks.SelectedItems[0].SubItems[1].Text;
                        listView_networks.Items.Remove(eachItem);
                        key.DeleteSubKey(netremv);
                    }
                }
                button_close.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error code:\n" + ex.ToString(), "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_clearall_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("This will delete all saved network.\nDo you want to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult1 == DialogResult.Yes)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList", true))
                    {
                        key.DeleteSubKeyTree("Profiles");
                        key.CreateSubKey("Profiles");
                    }
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(signatures, true))
                    {
                        key.DeleteSubKeyTree("Managed");
                        key.CreateSubKey("Managed");
                        key.DeleteSubKeyTree("Unmanaged");
                        key.CreateSubKey("Unmanaged");
                    }
                    NetworkLocations();
                    DialogResult dialogResult2 = MessageBox.Show("Done. It is recommended to restart network adapter.\nDo you want to open Network Connections?", "Restart network adapter", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        Process process = new System.Diagnostics.Process();
                        ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C explorer.exe ::{7007ACC7-3202-11D1-AAD2-00805FC1270E}";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error code:\n" + ex.ToString(), "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            NetworkLocations();
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listView_networks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_networks.SelectedItems.Count > 0)
                button_delete.Enabled = true;
            else
                button_delete.Enabled = false;
        }
    }
}