using System.IO.Ports;

namespace C_WithArduino
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        string[] portlar = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;

            }
            label2.Text = "Baðlantý Kapalý";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            label2.Text = "Baðlantý Açýk";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label2.Text = "Baðlantý Kapalý";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label1.Text = "Led Söndü";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "Led Yandý";
        }
    }
}