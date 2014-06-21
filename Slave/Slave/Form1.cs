using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(ports);
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboBoxPort.SelectedItem.ToString();
        }

        private void comboBoxBaund_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = Int32.Parse(comboBoxBaund.SelectedItem.ToString());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // TO DO!   Zacząłem, można robić zupełnie inaczej :)
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                textBoxConsole.AppendText(ex.ToString());
            }
        }
    }
}
