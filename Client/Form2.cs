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
using ClassLibrary1;
using System.IO;
using System.Diagnostics;

namespace HWC
{
    public partial class Form2 : Form
    {
        private NetworkStream m_networkstream;
        private TcpClient m_client;
        private byte[] sendBuffer = new byte[1024 * 20];
        private byte[] readBuffer = new byte[1024 * 20];
        private bool m_bConnect = false;
        public Initialize m_initializeClass;
        public Login m_loginClass;
        public Info m_infoClass;
        
        public Form2()
        {
            InitializeComponent();
        }
       
        public void setPlus(TreeNode node)
        {

            string path;
            DirectoryInfo dir;
            DirectoryInfo[] dl;
            try
            {
                path = node.FullPath;
                Info spath = new Info();
                spath.Type = (int)PacketType.정보;
                spath.m_strID = path;
                spath.user_select = "setPlus";
                Packet.Serialize(spath).CopyTo(this.sendBuffer, 0);
                this.Send();
                int nRead = 0;

                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
                }
                catch
                {
                    this.m_bConnect = false;
                    this.m_networkstream = null;
                }

                m_infoClass = (Info)Packet.Desserialize(this.readBuffer);

                dl = m_infoClass.m_d1;

                if (dl.Length > 0)
                    node.Nodes.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OpenFiles()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;
            foreach (ListViewItem item in siList)
                OpenItem(item);


        }

        public void OpenItem(ListViewItem item)
        {
            TreeNode node;
            TreeNode child;
            if (item.Tag.ToString() == "D")
            {
                node = trvDir.SelectedNode;
                node.Expand();
                child = node.FirstNode;
                while (child != null)
                {
                    if (child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();
                        break;
                    }
                    child = child.NextNode;
                }
            }
            else
            {
                string name =item.SubItems[0].Text;
                string kind = item.SubItems[4].Text;
                string location = item.SubItems[3].Text;
                string size = item.SubItems[1].Text;
                string make = item.SubItems[5].Text;
                string modify =item.SubItems[2].Text;
                string access = item.SubItems[6].Text;
                int index = Int32.Parse(item.SubItems[7].Text);
                if (kind != "folder")
                {
                    Form3 frm = new Form3(name, kind, location, size, make, modify, access, index);
                    frm.Show();
                }
                else
                {

                    Form3 frm = new Form3(name, kind, location, size, make, modify, access, 0);
                    frm.Show();
                }
            }
        }
        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;
            TreeNode node;
            try
            {
                e.Node.Nodes.Clear();
                path = e.Node.FullPath;
                Info spath = new Info();
                spath.Type = (int)PacketType.정보;
                spath.m_strID = path;
                spath.user_select = "beforeExpand";
                Packet.Serialize(spath).CopyTo(this.sendBuffer, 0);
                this.Send();
                int nRead = 0;
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
                }
                catch
                {
                    this.m_bConnect = false;
                    this.m_networkstream = null;
                }

                m_infoClass = (Info)Packet.Desserialize(this.readBuffer);
                di = m_infoClass.m_d1;
                foreach (DirectoryInfo dirs in di)
                {
                    node = e.Node.Nodes.Add(dirs.Name);
                    setPlus(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void treeview()
        {
            int nRead = 0;
            try
            {
                nRead = 0;
                nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
            }
            catch
            {
                this.m_bConnect = false;
                this.m_networkstream = null;
            }

            m_loginClass = (Login)Packet.Desserialize(this.readBuffer);

            TreeNode root;
            root = trvDir.Nodes.Add(m_loginClass.m_strID); // 서버에서 받은 경로
            if (trvDir.SelectedNode == null)
                trvDir.SelectedNode = root;
            root.SelectedImageIndex = root.ImageIndex;
            root.Nodes.Add("");
        }

        private void onserverbtn_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("경로를 입력하세요");
            else if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("IP 또는 PORT 번호를 입력하세요");
            else
            {
                if (onserverbtn.Text == "서버연결")
                {
                    this.m_client = new TcpClient();
                    try
                    {
                        this.m_client.Connect(textBox1.Text, Int32.Parse(textBox2.Text));
                        onserverbtn.Text = "연결끊기";
                    }
                    catch
                    {
                        MessageBox.Show("접속 에러");
                        return;
                    }
                    this.m_bConnect = true;
                    this.m_networkstream = this.m_client.GetStream();

                    treeview();
                }
                else if (onserverbtn.Text == "연결끊기")
                {
                    if (!this.m_bConnect)
                        return;
                    Initialize Init = new Initialize();
                    Init.Type = (int)PacketType.초기화;
                    Init.Data = Int32.Parse(textBox3.Text);
                    Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);

                }
            }
        }
        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo[] diarray;
            ListViewItem item;
            FileInfo[] fiArray;
            try
            {
                string path = e.Node.FullPath;
                Info spath = new Info();
                spath.Type = (int)PacketType.정보;
                spath.m_strID = path;
                spath.user_select = "beforeSelect";
                Packet.Serialize(spath).CopyTo(this.sendBuffer, 0);
                this.Send();
                int nRead = 0;
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
                }
                catch
                {
                    this.m_bConnect = false;
                    this.m_networkstream = null;
                }

                m_infoClass = (Info)Packet.Desserialize(this.readBuffer);
                lvwFiles.Items.Clear();
                diarray = m_infoClass.m_d1;
                fiArray = m_infoClass.m_f1;
                foreach (DirectoryInfo tdis in diarray)
                {

                    item = lvwFiles.Items.Add(tdis.Name);
                    item.SubItems.Add("folder");
                    item.SubItems.Add(tdis.LastWriteTime.ToString());
                    item.SubItems.Add(tdis.FullName.ToString());
                    item.SubItems.Add("ffolder");
                    item.SubItems.Add(tdis.CreationTime.ToString());
                    item.SubItems.Add(tdis.LastAccessTime.ToString());
                    item.ImageIndex = 0;
                    item.SubItems.Add("0");
                    item.Tag = "D";
                }
                foreach (FileInfo fis in fiArray)
                {
                    item = lvwFiles.Items.Add(fis.Name);
                    item.SubItems.Add(fis.Length.ToString());
                    item.SubItems.Add(fis.LastWriteTime.ToString());
                    item.SubItems.Add(fis.FullName.ToString());
                    item.SubItems.Add(fis.Extension.ToString());
                    item.SubItems.Add(fis.CreationTime.ToString());
                    item.SubItems.Add(fis.LastAccessTime.ToString());
                    item.Tag = "F";
                    string[] result = fis.Name.Split('.');
                    if (result[result.Length - 1] == "txt")
                    {
                        item.ImageIndex = 4;
                    }
                    else if (result[result.Length - 1] == "avi")
                    {
                        item.ImageIndex = 1;
                    }
                    else if (result[result.Length - 1] == "mp3")
                    {
                        item.ImageIndex = 3;
                    }
                    else if (result[result.Length - 1] == "png")
                    {
                        item.ImageIndex = 2;
                    }
                    else
                        item.ImageIndex = 5;
                    item.SubItems.Add(item.ImageIndex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
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
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Process.Start(textBox3.Text);
            }
            else
            {
                MessageBox.Show("경로를 입력하세요");
            }
        }
        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenFiles();
        }
        private void 상세정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;

            string name = siList[0].SubItems[0].Text;
            string kind = siList[0].SubItems[4].Text;
            string location = siList[0].SubItems[3].Text;
            string size = siList[0].SubItems[1].Text;
            string make = siList[0].SubItems[5].Text;
            string modify = siList[0].SubItems[2].Text;
            string access = siList[0].SubItems[6].Text;
            int index = Int32.Parse(siList[0].SubItems[7].Text);
            if (kind != "folder")
            {

                Form3 frm = new Form3(name, kind, location, size, make, modify, access, index);
                frm.Show();
            }
            else
            {

                Form3 frm = new Form3(name, kind, location, size, make, modify, access, 0);
                frm.Show();
            }


        }

        private void 다운로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;
            if (siList[0].Tag == "F")
            {
                string path = siList[0].SubItems[3].Text;
                Info spath = new Info();
                spath.Type = (int)PacketType.정보;
                spath.m_strID = path;
                spath.filesize = Int32.Parse(siList[0].SubItems[1].Text);
                spath.user_select = "download";
                Packet.Serialize(spath).CopyTo(this.sendBuffer, 0);
                this.Send();
                int nRead = 0;
                try
                {

                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 20);
                    
                }
                catch
                {
                    this.m_bConnect = false;
                    this.m_networkstream = null;
                }

                m_infoClass = (Info)Packet.Desserialize(this.readBuffer);
                FileStream fs = File.Open(textBox3.Text+"\\"+siList[0].SubItems[0].Text, FileMode.Create);
                using (BinaryWriter wr = new BinaryWriter(fs))
                {
                    wr.Write(m_infoClass.fileByteArray); // bytes
                }
                

            }
            else
            {
                MessageBox.Show("폴더는 다운로드할수없습니다.");
            }
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            mnuDetail.Checked = false;
            mnuList.Checked = false;
            mnuSmall.Checked = false;
            mnuLarge.Checked = false;
            switch (item.Text)
            {
                case "자세히":
                    mnuDetail.Checked = true;
                    lvwFiles.View = View.Details;
                    break;
                case "간단히":
                    mnuList.Checked = true;
                    lvwFiles.View = View.List;
                    break;
                case "작은아이콘":
                    mnuSmall.Checked = true;
                    lvwFiles.View = View.SmallIcon;
                    break;
                case "큰아이콘":
                    mnuLarge.Checked = true;
                    lvwFiles.View = View.LargeIcon;
                    break;

            }
        }

    }
}
