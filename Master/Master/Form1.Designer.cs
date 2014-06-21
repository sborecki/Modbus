namespace Master
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericAdress = new System.Windows.Forms.NumericUpDown();
            this.radioButtonBroadcast = new System.Windows.Forms.RadioButton();
            this.radioButtonAdressed = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBaund = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTimeBetweenChars = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericRetransmisions = new System.Windows.Forms.NumericUpDown();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeBetweenChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetransmisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Rozkaz";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(77, 96);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(61, 20);
            this.textBoxCommand.TabIndex = 31;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(305, 101);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 30;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Adres";
            // 
            // numericAdress
            // 
            this.numericAdress.Location = new System.Drawing.Point(12, 96);
            this.numericAdress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numericAdress.Name = "numericAdress";
            this.numericAdress.Size = new System.Drawing.Size(59, 20);
            this.numericAdress.TabIndex = 28;
            this.numericAdress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonBroadcast
            // 
            this.radioButtonBroadcast.AutoSize = true;
            this.radioButtonBroadcast.Checked = true;
            this.radioButtonBroadcast.Location = new System.Drawing.Point(101, 52);
            this.radioButtonBroadcast.Name = "radioButtonBroadcast";
            this.radioButtonBroadcast.Size = new System.Drawing.Size(103, 17);
            this.radioButtonBroadcast.TabIndex = 27;
            this.radioButtonBroadcast.TabStop = true;
            this.radioButtonBroadcast.Text = "Rozgłoszeniowy";
            this.radioButtonBroadcast.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdressed
            // 
            this.radioButtonAdressed.AutoSize = true;
            this.radioButtonAdressed.Location = new System.Drawing.Point(12, 52);
            this.radioButtonAdressed.Name = "radioButtonAdressed";
            this.radioButtonAdressed.Size = new System.Drawing.Size(83, 17);
            this.radioButtonAdressed.TabIndex = 26;
            this.radioButtonAdressed.Text = "Adresowany";
            this.radioButtonAdressed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
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
            this.comboBoxBaund.TabIndex = 24;
            this.comboBoxBaund.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaund_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Port";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(12, 25);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(59, 21);
            this.comboBoxPort.TabIndex = 17;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboPortMaster_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Czas pomiędzy znakami";
            // 
            // numericTimeBetweenChars
            // 
            this.numericTimeBetweenChars.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTimeBetweenChars.Location = new System.Drawing.Point(375, 64);
            this.numericTimeBetweenChars.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTimeBetweenChars.Name = "numericTimeBetweenChars";
            this.numericTimeBetweenChars.Size = new System.Drawing.Size(120, 20);
            this.numericTimeBetweenChars.TabIndex = 21;
            this.numericTimeBetweenChars.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Retransmisje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Timeout";
            // 
            // numericRetransmisions
            // 
            this.numericRetransmisions.Location = new System.Drawing.Point(375, 38);
            this.numericRetransmisions.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRetransmisions.Name = "numericRetransmisions";
            this.numericRetransmisions.Size = new System.Drawing.Size(120, 20);
            this.numericRetransmisions.TabIndex = 18;
            // 
            // numericTimeout
            // 
            this.numericTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTimeout.Location = new System.Drawing.Point(375, 12);
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
            this.numericTimeout.TabIndex = 16;
            this.numericTimeout.ThousandsSeparator = true;
            this.numericTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTimeout.ValueChanged += new System.EventHandler(this.numericTimeout_ValueChanged);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 130);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(483, 241);
            this.textBoxConsole.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 383);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericAdress);
            this.Controls.Add(this.radioButtonBroadcast);
            this.Controls.Add(this.radioButtonAdressed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBaund);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericTimeBetweenChars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRetransmisions);
            this.Controls.Add(this.numericTimeout);
            this.Name = "Form1";
            this.Text = "Modbus-Master";
            ((System.ComponentModel.ISupportInitialize)(this.numericAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeBetweenChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetransmisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAdress;
        private System.Windows.Forms.RadioButton radioButtonBroadcast;
        private System.Windows.Forms.RadioButton radioButtonAdressed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBaund;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTimeBetweenChars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericRetransmisions;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.IO.Ports.SerialPort serialPort;

    }
}

