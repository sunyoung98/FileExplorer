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
using System.Threading;
using System.IO;
using ClassLibrary1;




namespace HW2
{

    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        private TcpListener m_listener;
        private byte[] sendBuffer = new byte[1024 * 20];
        private byte[] readBuffer = new byte[1024 * 20];
        private bool m_bClientOn = false;
        private Thread m_thread;
        public Initialize m_initializeClass;
        public Login m_loginClass;
        public Info m_infoClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            this.m_networkstream.Close();
            this.m_thread.Abort();
        }
        private void pathselectbtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;
            textBox3.Text = selected;

        }
        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();
            for (int i = 0; i < 1024 * 20; i++)
                this.sendBuffer[i] = 0;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)

        {        //숫자와  " - "  표시가 아닌 다른문자는 입력되지 않습니다.  || 을사용하여 다른 문자를 포함할 수 있습니다. 

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))
            {

                e.Handled = true;

            }

        }

        private void onserverbtn_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("경로를 입력하세요");
            else if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("IP 또는 PORT 번호를 입력하세요");
            else
            {
                if (onserverbtn.Text == "서버켜기")
                {
                    this.m_thread = new Thread(new ThreadStart(RUN));
                    this.m_thread.Start();
                    onserverbtn.Text = "서버종료";


                }

                else
                {

                    onserverbtn.Text = "서버켜기";

                }
            }
        }
        public void RUN()
        {
            this.m_listener = new TcpListener(Int32.Parse(textBox2.Text));
            this.m_listener.Start();
            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    textBox4.AppendText("클라이언트 접속 대기중.... ");
                }));
            }
            TcpClient client = this.m_listener.AcceptTcpClient();
            if (client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    textBox4.AppendText("클라이언트 접속.... ");
                }));
                m_networkstream = client.GetStream();

                Login dirpath = new Login();
                dirpath.Type = (int)PacketType.로그인;
                dirpath.m_strID = textBox3.Text;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    textBox4.Text += dirpath.m_strID + "\n";
                }));
                Packet.Serialize(dirpath).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
            //MessageBox.Show("waiting");
            int nRead = 0;
            while (this.m_bClientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
                }
                catch
                {
                    this.m_bClientOn = false;
                    this.m_networkstream = null;
                }
                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);
                switch ((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        {
                            this.m_initializeClass = (Initialize)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                textBox4.AppendText("패킷 전송 선공.... ");
                               

                            }));
                            break;
                        }
                    case (int)PacketType.로그인:
                        {
                            this.m_loginClass =
                                (Login)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                textBox4.AppendText("패킷 전송 성공" + this.m_loginClass.m_strID + "...");

                            }));
                            break;
                        }
                    case (int)PacketType.정보:
                        {
                            
                            this.m_infoClass =
                                (Info)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                textBox4.AppendText("패킷 전송 성공" + this.m_infoClass.m_strID + "...");

                            }));
                            if (this.m_infoClass.user_select == "download") {
                                MessageBox.Show(this.m_infoClass.m_strID);
                                Info dirpath = new Info();
                                using (BinaryReader rdr = new BinaryReader(File.Open(this.m_infoClass.m_strID, FileMode.Open)))
                                {
                                    dirpath.fileByteArray = rdr.ReadBytes(1024 * 20);
                                }
                                    
                                dirpath.Type = (int)PacketType.정보;
                                Packet.Serialize(dirpath).CopyTo(this.sendBuffer, 0);
                                this.Send();
                                textBox4.AppendText("파일 보내기 완료...");




                            }
                            else
                            {
                                Info dirpath = new Info();
                                dirpath.Type = (int)PacketType.정보;
                                dirpath.m_d1 = new DirectoryInfo(m_infoClass.m_strID).GetDirectories();
                                dirpath.m_f1 = new DirectoryInfo(m_infoClass.m_strID).GetFiles();

                                Packet.Serialize(dirpath).CopyTo(this.sendBuffer, 0);
                                this.Send();
                                textBox4.AppendText("데이터 보내기 완료...");
                            }
                            break;
                        }
                }

            }

        }



    }
}