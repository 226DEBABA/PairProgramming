using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformControlUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "黄本巍" && textBox2.Text == "123456")
            {
                MessageBox.Show("欢迎登录！", "提示");
                this.Hide();
                FrmStudent frmStudent = new FrmStudent();
                frmStudent.Show();



            }
            if (textBox1.Text == "付昶宇" && textBox2.Text == "123456")
            {
                MessageBox.Show("欢迎登录！", "提示");
                this.Hide();
                FrmStudent frmStudent = new FrmStudent();
                frmStudent.Show();



            }

        }
    }
}
