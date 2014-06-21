namespace Modbus_RS232
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericAdress = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBaundMaster = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPortMaster = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTimeBetweenChars = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericRetransmisions = new System.Windows.Forms.NumericUpDown();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxBaundSlave = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboPortSlave = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeBetweenChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetransmisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxConsole);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxCommand);
            this.tabPage1.Controls.Add(this.buttonSend);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numericAdress);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBaundMaster);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboPortMaster);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericTimeBetweenChars);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericRetransmisions);
            this.tabPage1.Controls.Add(this.numericTimeout);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Master";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(6, 137);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(479, 178);
            this.textBoxConsole.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rozkaz";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(71, 95);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(61, 20);
            this.textBoxCommand.TabIndex = 14;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(295, 95);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres";
            // 
            // numericAdress
            // 
            this.numericAdress.Location = new System.Drawing.Point(6, 95);
            this.numericAdress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numericAdress.Name = "numericAdress";
            this.numericAdress.Size = new System.Drawing.Size(59, 20);
            this.numericAdress.TabIndex = 11;
            this.numericAdress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(95, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rozgłoszeniowy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Adresowany";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bound Rate";
            // 
            // comboBaundMaster
            // 
            this.comboBaundMaster.FormattingEnabled = true;
            this.comboBaundMaster.Items.AddRange(new object[] {
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
            this.comboBaundMaster.Location = new System.Drawing.Point(71, 24);
            this.comboBaundMaster.Name = "comboBaundMaster";
            this.comboBaundMaster.Size = new System.Drawing.Size(61, 21);
            this.comboBaundMaster.TabIndex = 7;
            this.comboBaundMaster.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // comboPortMaster
            // 
            this.comboPortMaster.FormattingEnabled = true;
            this.comboPortMaster.Location = new System.Drawing.Point(6, 24);
            this.comboPortMaster.Name = "comboPortMaster";
            this.comboPortMaster.Size = new System.Drawing.Size(59, 21);
            this.comboPortMaster.TabIndex = 1;
            this.comboPortMaster.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Czas pomiędzy znakami";
            // 
            // numericTimeBetweenChars
            // 
            this.numericTimeBetweenChars.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTimeBetweenChars.Location = new System.Drawing.Point(365, 58);
            this.numericTimeBetweenChars.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTimeBetweenChars.Name = "numericTimeBetweenChars";
            this.numericTimeBetweenChars.Size = new System.Drawing.Size(120, 20);
            this.numericTimeBetweenChars.TabIndex = 4;
            this.numericTimeBetweenChars.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Retransmisje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timeout";
            // 
            // numericRetransmisions
            // 
            this.numericRetransmisions.Location = new System.Drawing.Point(365, 32);
            this.numericRetransmisions.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRetransmisions.Name = "numericRetransmisions";
            this.numericRetransmisions.Size = new System.Drawing.Size(120, 20);
            this.numericRetransmisions.TabIndex = 1;
            // 
            // numericTimeout
            // 
            this.numericTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTimeout.Location = new System.Drawing.Point(365, 6);
            this.numericTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(120, 20);
            this.numericTimeout.TabIndex = 0;
            this.numericTimeout.ThousandsSeparator = true;
            this.numericTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTimeout.ValueChanged += new System.EventHandler(this.numericTimeout_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBoxBaundSlave);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboPortSlave);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slave";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bound Rate";
            // 
            // comboBoxBaundSlave
            // 
            this.comboBoxBaundSlave.FormattingEnabled = true;
            this.comboBoxBaundSlave.Items.AddRange(new object[] {
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
            this.comboBoxBaundSlave.Location = new System.Drawing.Point(137, 19);
            this.comboBoxBaundSlave.Name = "comboBoxBaundSlave";
            this.comboBoxBaundSlave.Size = new System.Drawing.Size(61, 21);
            this.comboBoxBaundSlave.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Port";
            // 
            // comboPortSlave
            // 
            this.comboPortSlave.FormattingEnabled = true;
            this.comboPortSlave.Location = new System.Drawing.Point(72, 19);
            this.comboPortSlave.Name = "comboPortSlave";
            this.comboPortSlave.Size = new System.Drawing.Size(59, 21);
            this.comboPortSlave.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adres";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Modbus on RS-485";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeBetweenChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetransmisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericRetransmisions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTimeBetweenChars;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPortMaster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBaundMaster;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAdress;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxBaundSlave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboPortSlave;
    }
}

