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
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
namespace Gozzi_progetto
{
    public partial class Form1 : Form
    {
        Socket handler;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\jakib\OneDrive\Desktop\Gozzi_progetto\Gozzi_progetto_server\File\Indovinelli.txt";
            StreamReader FileTesto;
            try
            {
                int i = 0;
                string [] indovinelli = File.ReadAllLines(path);
                FileTesto = new StreamReader(path);
                while (!FileTesto.EndOfStream)
                {
                    textBox1.Text="Indovinello N°" + i + ":" + FileTesto.ReadLine();
                    i++;
                }
                FileTesto.Close();
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("I miei indovinelli sono scomparsi");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] bytes = new Byte[1024];
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                while (true)
                {
                    Console.WriteLine("in attesa di una connessione...");
                    Socket handler = listener.Accept();
                    ClientManager clientThread = new ClientManager(handler);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
    public class ClientManager
    {
        Socket handler;
        byte[] bytes = new Byte[1024];
        String Risposta = "";
        int conta_errori = 0;
        Random rand;
        public ClientManager(Socket clientSocket)
        {
            /*this.handler = clientSocket;
            MossaFinale = new bool[9];
            for (int i = 0; i < MossaFinale.Length; i++)
            {
                MossaFinale[i] = false;
            }
            rand = new Random();*/
        }
        public void doClient()
        {
            if (conta_errori == 5)
            {
                //Console.WriteLine
            }
        }
    }
}