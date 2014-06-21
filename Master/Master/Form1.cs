using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(ports);
        }

        private void comboPortMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboBoxPort.SelectedItem.ToString();
        }

        private void comboBoxBaund_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = Int32.Parse(comboBoxBaund.SelectedItem.ToString());
        }

        //Wysyłanie rozkazu
        private void buttonSend_Click(object sender, EventArgs e)
        {
            // TO DO!
        }

        private void numericTimeout_ValueChanged(object sender, EventArgs e)
        {
            serialPort.ReadTimeout = (int)numericTimeout.Value;
            serialPort.WriteTimeout = (int)numericTimeout.Value;
        }
    }
}
