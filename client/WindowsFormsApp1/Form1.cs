using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); 
        NetworkStream serverStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Client Started");
            try {
                clientSocket.Connect("10.10.21.29", 11000);
                MessageBox.Show("Client Socket Program - Server Connected ...");

                serverStream = clientSocket.GetStream();

                byte[] outStream = System.Text.Encoding.ASCII.GetBytes("ciao sono vano :D<EOF>");

                serverStream.Write(outStream, 0, outStream.Length);

                serverStream.Flush();

                byte[] inStream = new byte[(int)clientSocket.ReceiveBufferSize];

                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                MessageBox.Show("Data from Server : " + returndata);
            } catch (SocketException) {
                MessageBox.Show("oki non funziona ;-;");
            }
        }
    }
}
