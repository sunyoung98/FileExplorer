using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string s1, string s2, string s3, string s4, string s5, string s6, string s7, int index)
        {
            InitializeComponent();
            textBox1.Text = s1;
            kind.Text = s2.Substring(1, s2.Length - 1);
            location.Text = s3;
            size.Text = s4;
            make.Text = s5;
            modify.Text = s6;
            access.Text = s7;
            PB.Image = imageList1.Images[index];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
