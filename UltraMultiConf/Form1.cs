using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraMultiConf.Classes;

namespace UltraMultiConf
{
    public partial class UltraMultiConf : Form
    {
        public UltraMultiConf()
        {
            InitializeComponent();

            Logger.LogRTB = outputBox;
            Logger.Good("Welcome to UltraMultiConf!");
            
        }

        private void resetApp()
        {
            deviceList.Items.Clear();
            progressBar.Value = 0;
            tabControl1.SelectedTab = Setup;
        }

        private void telnetExecute(int inc)
        {
            Logger.Good("Beginning using Telnet...");

            int count = 0;

            foreach (string device in deviceList.Items)
            {
                Logger.Good("Connecting to '" + device + "' over Telnet...");
                TelnetConnection tc = new TelnetConnection(device, 23);

                string login = tc.Login(usernameInput.Text, passwordInput.Text, 1000);
                Logger.Info(login);

                string prompt = login.TrimEnd();
                prompt = login.Substring(prompt.Length - 1, 1);
                if (prompt != "$" && prompt != ">")
                {
                    Logger.Error("Connection Failed!");
                    continue;
                } 
                else 
                {
                    foreach (String command in commandsToSend.Lines)
                    {
                        tc.WriteLine(command);
                        Logger.Warning(" > " + command);
                        Logger.Info(tc.Read());
                    }
                }

                count++;
                if (count == deviceList.Items.Count)
                {
                    progressBar.Value = 100;
                } 
                else
                {
                    progressBar.Value += inc;
                }
            }

        }

        private void beginExecute()
        {
            progressBar.Value = 0;
            tabControl1.SelectedTab = tabPage3;
            Logger.Info("Initializing...");
            int totalDevices = deviceList.Items.Count;

            Logger.Info(totalDevices.ToString() + " devices in list.");

            int increments = 100 / totalDevices;
            //progressBar.Value = increments;

            statusLabel.Text = "Initializing...";
            if(telnetradiobtn.Checked)
            {
                telnetExecute(increments);
            } else
            {

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(ListBox.NoMatches == deviceList.FindStringExact(addDeviceInput.Text))
            {
                deviceList.Items.Add(addDeviceInput.Text);
                addDeviceInput.Clear();
            }
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeBtn.Enabled = true;
        }

        private void addDeviceInput_TextChanged(object sender, EventArgs e)
        {
            if(addDeviceInput.Text != "")
            {
                addBtn.Enabled = true;
            } else
            {
                addBtn.Enabled = false;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            deviceList.Items.Remove(deviceList.SelectedItem);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (executeBtn.Text == "Next")
            {
                tabControl1.SelectedTab = tabPage2;
                executeBtn.Text = "Execute!";
            }
            else if (executeBtn.Text == "Execute!")
            {
                beginExecute();
                executeBtn.Text = "Reset";
            }
            else
            {
                executeBtn.Text = "Next";
                resetApp();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                MessageBox.Show("SSH isn't implemented yet! (sorry...)", "Sorry!");
            telnetradiobtn.Checked = true;
               
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Setup":
                    executeBtn.Text = "Next";
                    break;
                case "Commands":
                    executeBtn.Text = "Execute!";
                    break;
                case "Output":
                    executeBtn.Text = "Reset";
                    break;
            }
        }
    }
}
