using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Modbus_RS232
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboPortMaster.Items.AddRange(ports);
            comboPortSlave.Items.AddRange(ports);
            comboPortMaster.SelectedIndex = comboPortMaster.Items.Count-1;
            comboPortSlave.SelectedItem = comboPortSlave.Items.Count - 1;
            comboBaundMaster.SelectedItem = "9600";
            comboBoxBaundSlave.SelectedItem = "9600";
        }

        private void numericTimeout_ValueChanged(object sender, EventArgs e)
        {
            serialPort.WriteTimeout = (int)numericTimeout.Value;
            serialPort.ReadTimeout = (int)numericTimeout.Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = Int32.Parse(comboBaundMaster.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboPortMaster.SelectedItem.ToString();
        }

        private byte lrc(byte[] b)
        {
            byte lrc = 0;
            for (int i = 0; i < b.Length; i++)
                lrc ^= b[i];
            return lrc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Parity = Parity.Even;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                serialPort.Write(new byte[] { Convert.ToByte(numericAdress.Value), 0x02, 0x03 }, 0, 3);
                textBoxConsole.AppendText("0x" + 255.ToString("X2") + Environment.NewLine);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                textBoxConsole.AppendText(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
