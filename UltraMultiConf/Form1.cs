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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(ListBox.NoMatches == deviceList.FindStringExact(addDeviceInput.Text))
            {
                deviceList.Items.Add(addDeviceInput.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Info("Starting Execution!");
        }
    }
}
