using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace pókchat
{
    public partial class Form1 : Form
    {
        //Declare Variables
        Socket sck;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();
            //Declare Sockets
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //tbClientIP.PlaceholderText = GetLocalIP();
            desObj = Aes.Create();


        }
        //global variables
        string cipherData;
        string decipher;
        byte[] chipherBytes;
        byte[] plainBytes;
        byte[] plainBytes2;
        byte[] plainKey;
        SymmetricAlgorithm desObj;

        private string GetLocalIP()
        {
        //Get Local Ip (For ease of Use)
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork);
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }


        public void encrypt()
        {
            //encryption
            cipherData = tbChat.Text;
            plainBytes = Encoding.ASCII.GetBytes(cipherData);
            plainKey = Encoding.ASCII.GetBytes("xobamaprism42069");
            desObj.Key = plainKey;
            //Choose another mode (CBC, CFB, CTS, ECB, OFB)
            desObj.Mode = CipherMode.CBC;
            desObj.Padding = PaddingMode.Zeros;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, desObj.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(plainBytes, 0, plainBytes.Length);
            cs.Close();
            chipherBytes = ms.ToArray();
            ms.Close();
            tbChat.Text = Encoding.ASCII.GetString(chipherBytes);
        }

         public void Decrypt()
        {
            System.IO.MemoryStream recievedMessage = new System.IO.MemoryStream(chipherBytes);
            CryptoStream cs1 = new CryptoStream(recievedMessage, desObj.CreateDecryptor(), CryptoStreamMode.Read);
            cs1.Read(chipherBytes, 0, chipherBytes.Length);
            plainBytes2 = recievedMessage.ToArray();
            cs1.Close();

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
        //detecting messages and showing
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    Decrypt(receivedMessage);
                    lbChat.Items.Add(tbRecievingIP.Text + ":" + tbRecievingPort.Text + " - " + receivedMessage);

                }
                byte[] buffer = new byte[1500];

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btConnect_Click(object sender, EventArgs e)
        {//Connecting
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(tbClientIP.Text), Convert.ToInt32(tbClientPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(tbRecievingIP.Text), Convert.ToInt32(tbRecievingPort.Text));
                    sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                btConnect.Enabled = false;
                btSend.Enabled = true;
                tbChat.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {//sending
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                lbChat.Items.Add("Client - " + tbChat.Text);
                encrypt();
                msg = enc.GetBytes(tbChat.Text);

                
                sck.Send(msg);
             
                tbChat.Clear();
                tbChat.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btConnect.Enabled = true;
            //btSend.Enabled = false;
            btSend.BackColor = Color.FromArgb(44, 47, 51);
            btConnect.BackColor = Color.FromArgb(44, 47, 51);
            List<Color> lstColour = new List<Color>();
            foreach (Control c in groupBox1.Controls)
                lstColour.Add(c.ForeColor);

            groupBox1.ForeColor = Color.White; //the colour you prefer for the text

            int index = 0;
            foreach (Control c in groupBox1.Controls)
            {
                c.ForeColor = lstColour[index];
                index++;
            }

            List<Color> lstColour2 = new List<Color>();
            foreach (Control c in groupBox2.Controls)
                lstColour2.Add(c.ForeColor);

            groupBox2.ForeColor = Color.White; //the colour you prefer for the text

            int index2 = 0;
            foreach (Control c in groupBox1.Controls)
            {
                c.ForeColor = lstColour[index2];
                index++;
            }
            //MessageBox.Show("Pókchat (Spiderchat) V1.0 Unencrypted, Made by crinobaka and CaptainK", "Credits");
        }
    }
}
