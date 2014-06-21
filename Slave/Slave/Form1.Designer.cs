namespace Slave
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBaund = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericAdress = new System.Windows.Forms.NumericUpDown();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Bound Rate";
            // 
            // comboBoxBaund
            // 
            this.comboBoxBaund.FormattingEnabled = true;
            this.comboBoxBaund.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaund.Location = new System.Drawing.Point(77, 25);
            this.comboBoxBaund.Name = "comboBoxBaund";
            this.comboBoxBaund.Size = new System.Drawing.Size(61, 21);
            this.comboBoxBaund.TabIndex = 28;
            this.comboBoxBaund.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaund_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Port";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(12, 25);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(59, 21);
            this.comboBoxPort.TabIndex = 26;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adres";
            // 
            // numericAdress
            // 
            this.numericAdress.Location = new System.Drawing.Point(144, 25);
            this.numericAdress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numericAdress.Name = "numericAdress";
            this.numericAdress.Size = new System.Drawing.Size(59, 20);
            this.numericAdress.TabIndex = 30;
            this.numericAdress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(356, 25);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 32;
            this.buttonOpen.Text = "Otwórz port";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 54);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(419, 318);
            this.textBoxConsole.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 384);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBaund);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPort);
            this.Name = "Form1";
            this.Text = "Modbus-Slave";
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBaund;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAdress;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxConsole;
    }
}

