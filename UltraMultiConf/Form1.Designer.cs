
namespace UltraMultiConf
{
    partial class UltraMultiConf
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceList = new System.Windows.Forms.ListBox();
            this.addDeviceInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.commandsToSend = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.configLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Setup = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Setup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.FormattingEnabled = true;
            this.deviceList.ItemHeight = 15;
            this.deviceList.Location = new System.Drawing.Point(3, 81);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(190, 394);
            this.deviceList.TabIndex = 0;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectedIndexChanged);
            // 
            // addDeviceInput
            // 
            this.addDeviceInput.Location = new System.Drawing.Point(3, 25);
            this.addDeviceInput.Name = "addDeviceInput";
            this.addDeviceInput.Size = new System.Drawing.Size(190, 23);
            this.addDeviceInput.TabIndex = 1;
            this.addDeviceInput.TextChanged += new System.EventHandler(this.addDeviceInput_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Location = new System.Drawing.Point(3, 54);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(3, 7);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(137, 15);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Hostname or IP Address:";
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(98, 54);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(95, 23);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // commandsToSend
            // 
            this.commandsToSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commandsToSend.Location = new System.Drawing.Point(6, 21);
            this.commandsToSend.Name = "commandsToSend";
            this.commandsToSend.Size = new System.Drawing.Size(852, 454);
            this.commandsToSend.TabIndex = 5;
            this.commandsToSend.Text = "";
            this.commandsToSend.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.outputBox.Location = new System.Drawing.Point(3, 18);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(844, 457);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(3, 3);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(142, 15);
            this.configLabel.TabIndex = 7;
            this.configLabel.Text = "Enter commands to send:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output:";
            // 
            // executeBtn
            // 
            this.executeBtn.Enabled = false;
            this.executeBtn.Location = new System.Drawing.Point(673, 524);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(190, 31);
            this.executeBtn.TabIndex = 9;
            this.executeBtn.Text = "Execute!";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Setup);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 506);
            this.tabControl1.TabIndex = 10;
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.addLabel);
            this.Setup.Controls.Add(this.addDeviceInput);
            this.Setup.Controls.Add(this.deviceList);
            this.Setup.Controls.Add(this.removeBtn);
            this.Setup.Controls.Add(this.addBtn);
            this.Setup.Location = new System.Drawing.Point(4, 24);
            this.Setup.Name = "Setup";
            this.Setup.Padding = new System.Windows.Forms.Padding(3);
            this.Setup.Size = new System.Drawing.Size(859, 478);
            this.Setup.TabIndex = 0;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.commandsToSend);
            this.tabPage2.Controls.Add(this.configLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.outputBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UltraMultiConf
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.executeBtn);
            this.MaximizeBox = false;
            this.Name = "UltraMultiConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraMultiConf";
            this.tabControl1.ResumeLayout(false);
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox deviceList;
        private System.Windows.Forms.TextBox addDeviceInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.RichTextBox commandsToSend;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

