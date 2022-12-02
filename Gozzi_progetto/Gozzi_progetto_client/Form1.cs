using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gozzi_progetto_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket SOCKET;
        private void button1_Click(object sender, EventArgs e)
        {
            void Connetti(string messaggio)
            {
                byte[] bytes = new byte[1024];
                try
                {
                    // Establish the remote endpoint for the socket.  
                    // This example uses port 11000 on the local computer.  
                    IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);
                    SOCKET = new Socket(ipAddress.AddressFamily,
                       SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        SOCKET.Connect(remoteEP);
                        Console.WriteLine("Socket connected to {0}",
                            SOCKET.RemoteEndPoint.ToString());
                    }
                    catch (ArgumentNullException ane)
                    {
                        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        Console.WriteLine("SocketException : {0}", se.ToString());
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Unexpected exception : {0}", a.ToString());
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.ToString());
                }
                Connetti(messaggio);
                Console.WriteLine("Premere un tasto per continuare ");
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.
        }
    }
}